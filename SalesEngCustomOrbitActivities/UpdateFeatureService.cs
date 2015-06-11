using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using System.Net;
using Newtonsoft.Json;
using JsonToCS;
using Newtonsoft.Json.Linq;

namespace SalesEngCustomOrbitActivities
{
    public sealed class UpdateFeatureService : CodeActivity<string>
    {        
        // Define an activity input argument of type string
        [RequiredArgument]
        public InArgument<String> URL { get; set; }
        [RequiredArgument]
        public InArgument<Dictionary<string,string>> Attributes { get; set; }

        protected override String Execute(CodeActivityContext context)
        {
            try
            {
                var stringStringAttDict = Attributes.Get(context);
                string url = URL.Get(context);

                return DoUpdateFeatureService(stringStringAttDict, url).ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
            }
        }

        private bool DoUpdateFeatureService(Dictionary<string, string> attributes, string URL)
        {
            List<string> fieldValuePairs = new List<string>();
            foreach (KeyValuePair<string, string> kvp in attributes)
            {
                fieldValuePairs.Add("\"" + kvp.Key + "\":" + kvp.Value);
            }
            var fieldValuePairsArray = fieldValuePairs.ToArray();
            string features = "[{\"attributes\" : {" + String.Join(",", fieldValuePairsArray) + "}}]";

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

            WebClient client = new WebClient();
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            //var response = client.UploadString(Url.Get(context), postBody);
            var response = client.UploadString(URL, postBody);
            var result = JObject.Parse(response);
            bool success = (bool)result["updateResults"][0]["success"];
            Console.WriteLine(response);
            return success;
        }
    }
}
