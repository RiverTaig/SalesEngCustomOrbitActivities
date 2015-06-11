using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Activities;
using SE.Orbit.TaskServices;

namespace SalesEngCustomOrbitActivities
{
    public sealed class GetTasksTaskType : CodeActivity<TaskTypeResource>
    {
        // Define an activity input argument of type string
        public InArgument<TaskResource> Task { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override TaskTypeResource Execute(CodeActivityContext context)
        {
            TaskServicesClient client = new TaskServicesClient();
            client.UseApiKey(new Guid(ConfigurationManager.AppSettings["ApiKey"]));

            return Task.Get(context).GetTaskType(client).GetContentAsync().Result;
        }
    }
}
