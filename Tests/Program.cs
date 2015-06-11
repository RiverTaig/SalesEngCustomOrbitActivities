using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            string objectid = "1";
            Dictionary<string, string> inputDict = new Dictionary<string, string>() { 
                {"OPERATINGVOLTAGE","\"TESTer\""},
                {"CompletionDate","\"03-23-2023\""},
                {"TRANSFORMEROBJECTID","3"},
                {"TASKCOORDINATESX","456.789"}
            } ;

            string URL = "http://63.253.242.153/arcgis/rest/services/Orbit/ElectricOrbit/FeatureServer/32/addFeatures";
            //DoUpdateFeatureService(inputDict, URL, false);


            inputDict = new Dictionary<string, string>() { 
                {"OBJECTID",objectid},
                {"DateLastInspected","\"03-23-2023\""}
            };

            URL = "http://63.253.242.153/arcgis/rest/services/Orbit/ElectricOrbit/FeatureServer/3/updateFeatures";
            bool s = DoUpdateFeatureService(inputDict, URL, true);


        }


        private static bool DoUpdateFeatureService(Dictionary<string, string> attributes, string URL, bool update)
        {
            //http://63.253.242.153/arcgis/rest/services/Orbit/ElectricOrbit/FeatureServer/32/addFeatures
            List<string> fieldValuePairs = new List<string>();
            foreach (KeyValuePair<string, string> kvp in attributes)
            {
                fieldValuePairs.Add("\"" + kvp.Key + "\":" + kvp.Value);
            }
            var fieldValuePairsArray = fieldValuePairs.ToArray();
            string features = "[{\"attributes\" : {" + String.Join(",", fieldValuePairsArray) + "}}]";
            try
            {
                System.IO.File.WriteAllText(@"C:\temp\addFeatureRequest.txt", features);
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

            WebClient client = new WebClient();
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            //var response = client.UploadString(Url.Get(context), postBody);
            var response = client.UploadString(URL, postBody);
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
    }
}
