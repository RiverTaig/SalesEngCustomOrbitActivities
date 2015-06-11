using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using System.Net;
using Newtonsoft.Json;
using JsonToCS;
using Newtonsoft.Json.Linq;
using SE.Orbit.TaskServices;
using System.Configuration;
namespace SalesEngCustomOrbitActivities
{
    public sealed class UpdateFeatureServiceAndCreateRelatedRecord : CodeActivity<string>
    {
        // Define an activity input argument of type string
        [RequiredArgument]
        public InArgument<String> TransformerBankURL { get; set; }
        [RequiredArgument]
        public InArgument<String> TransformerInspectionURL { get; set; }
        [RequiredArgument]
        public InArgument<String> ObjectID { get; set; }
        [RequiredArgument]
        public InArgument<TaskResource> TaskRes { get; set; }
        //[RequiredArgument]
        //public InArgument<Dictionary<string, string>> Attributes { get; set; }

        protected override String Execute(CodeActivityContext context)
        {
            try
            {
                TaskResource tr = TaskRes.Get(context);
                string bankUrl = TransformerBankURL.Get(context);
                string unitUrl = TransformerInspectionURL.Get(context);

                string bank = DoUpdateFeatureService(tr, bankUrl, true).ToString();
                string unit = DoUpdateFeatureService(tr, unitUrl, false).ToString();
                return bank + " - " + unit;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
            }
        }
        private static bool DoUpdateFeatureService(TaskResource tr , string URL, bool update)
        {
            try
            {
                //tr.Location.Gps.Lat
                TaskServicesClient client = new TaskServicesClient();
                client.UseApiKey(new Guid(ConfigurationManager.AppSettings["ApiKey"]));
                
                TaskTypeResource type = tr.GetTaskType(client).GetContentAsync().Result;

                #region Code to demonstrate what is in the TaskResources Properties collection

                /*StringBuilder sb = new StringBuilder();
            sb.Append("Date completed = " + tr.CompletionDate);
            foreach (KeyValuePair<string, object> kvp in tr.Properties)
            {
                try
                {
                    sb.Append(",");
                    sb.Append(kvp.Key.ToString() + "|" + kvp.Value.ToString());
                }
                catch { 
                    sb.Append(kvp.Key.ToString() + "|????" ) ; 
                }
            }
            System.IO.File.WriteAllText(@"C:\temp\kvpContents.txt", sb.ToString());
            return true;*/
                #endregion

                List<string> fieldValuePairs = new List<string>();
                foreach (KeyValuePair<string, object> kvp in tr.Properties)
                {
                    if (update)
                    {
                        if ((kvp.Key.ToUpper().Contains("OBJECTID")))
                        {
                            string field = "OBJECTID";
                            fieldValuePairs.Add("\"" + field + "\":" + kvp.Value);
                            fieldValuePairs.Add("\"DateLastInspected\":" + "\"" + (DateTime.Now)   + "\"");
                            break;
                        }
                    }
                    else
                    {
                        //It's an add operation
                        string field = kvp.Key;
                        if ((kvp.Key.ToUpper().Contains("OBJECTID")))
                        {
                            field = "TransformerObjectID";
                        }
                        double doubRes = 0;
                        bool isNumeric = Double.TryParse(kvp.Value.ToString(), out doubRes);
                        PropertyType ptype = PropertyType.String;
                        try
                        {
                            TaskTypePropertyResource prop = type.Properties.Where(tt => tt.Name == field).FirstOrDefault();
                            ptype = prop.Type;
                        }
                        catch { }
                        if ( (ptype == PropertyType.String) || (ptype == PropertyType.Boolean) || (ptype==PropertyType.DateTime) ) 
                        {
                            if (ptype == PropertyType.DateTime)
                            {
                                DateTime? tzCorrect = (Convert.ToDateTime(kvp.Value) - new TimeSpan(6, 0, 0));
                                fieldValuePairs.Add("\"" + field + "\":" + "\"" + tzCorrect + "\"");
                            }
                            else { 
                                fieldValuePairs.Add("\"" + field + "\":" + "\"" + kvp.Value + "\"");
                            }
                            
                        }
                        else {
                            fieldValuePairs.Add("\"" + field + "\":" + kvp.Value);
                        }

                    }
                }
                fieldValuePairs.Add("\"" + "Status" + "\":" + "\"" + tr.Status.ToString() + "\"");
                DateTime? timeZoneCorrect = tr.CompletionDate - new TimeSpan(0, 6, 0, 0, 0);
                fieldValuePairs.Add("\"" + "CompletionDate" + "\":" + "\"" + timeZoneCorrect + "\"");
                fieldValuePairs.Add("\"" + "DueDate" + "\":" + "\"" + (tr.DueDate - new TimeSpan(0, 6, 0, 0, 0))  + "\"");
                //fieldValuePairs.Add("\"" + "TaskCoordinatesX" + "\":" + "\"" +  + "\"");
                //fieldValuePairs.Add("\"" + "TaskCoordinatesY" + "\":" + "\"" + kvp.Value + "\"");
                fieldValuePairs.Add("\"" + "TaskCoordinatesX" + "\":" + tr.Location.Gps.Lng);
                fieldValuePairs.Add("\"" + "TaskCoordinatesY" + "\":" + tr.Location.Gps.Lat);

                var fieldValuePairsArray = fieldValuePairs.ToArray();
                string features = "[{\"attributes\" : {" + String.Join(",", fieldValuePairsArray) + "}}]";
                try
                {
                    if (update)
                    {
                        System.IO.File.WriteAllText(@"C:\temp\updateFeatureRequest.txt", features);
                    }
                    else
                    {
                        System.IO.File.WriteAllText(@"C:\temp\addFeatureRequest.txt", features);
                    }
                }
                catch { }
                //features = "[{\"attributes\" : {\"OPERATINGVOLTAGE\":\"TEST\",\"CompletionDate\":\"01-23-2015\",\"TRANSFORMEROBJECTID\":3,\"TASKCOORDINATESX\":456.789}}]";


                Dictionary<string, string> parmsToRestCall = new Dictionary<string, string>(){
                {"features" , features},
                {"gdbVersion" , ""},
                {"rollbackOnFailure" , "true"},
                {"f" , "pjson"}
            };
                IEnumerable<string> values = parmsToRestCall.Select(x => string.Format("{0}={1}",
                    WebUtility.UrlEncode(x.Key),
                    WebUtility.UrlEncode(x.Value)));
                string postBody = string.Join("&", values);

                WebClient wc = new WebClient();
                wc.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                //var response = client.UploadString(Url.Get(context), postBody);
                var response = wc.UploadString(URL, postBody);
                var result = JObject.Parse(response);
                bool success = false;
                if (update)
                {
                    success = (bool)result["updateResults"][0]["success"];
                }
                else
                {
                    success = (bool)result["addResults"][0]["success"];
                }

                Console.WriteLine(response);
                return success;
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\temp\ERROR.txt", ex.ToString());
                return false;
            }
        }

    }
}
