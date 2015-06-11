using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Activities;
using Newtonsoft.Json.Linq;

namespace SalesEngCustomOrbitActivities
{

    public sealed class PostToFormEncodedService : CodeActivity<int>
    {
        // Define an activity input argument of type string
        public InArgument<Uri> Url { get; set; }
        public InArgument<Dictionary<string,string>> Arguments { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override int Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            var parameters = Arguments.Get(context);
            IEnumerable<string> values = parameters.Select(x => string.Format("{0}={1}",
                WebUtility.UrlEncode(x.Key),
                WebUtility.UrlEncode(x.Value)));
            string postBody = string.Join("&", values);

            WebClient client = new WebClient();
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            var response = client.UploadString(Url.Get(context), postBody);

            var result = JObject.Parse(response);
            int objid = (int)result["addResults"][0]["objectId"];


            //{"addResults":[{"objectId":1614,"globalId":"{1DAAC22E-38F1-4891-8DB0-FFED759A1A6A}","success":true}]}

            Console.WriteLine(response);
            return objid;
        }
    }
}
