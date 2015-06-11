using System;
using System.Activities;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SE.Orbit.TaskServices;

namespace SalesEngCustomOrbitActivities
{
    public sealed class CopyRedlines : CodeActivity
    {
        [RequiredArgument]
        public InArgument<TaskResource> FromTask { get; set; }

        [RequiredArgument]
        public InOutArgument<TaskResource> ToTask { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            TaskServicesClient client = new TaskServicesClient();
            client.UseApiKey(new Guid(ConfigurationManager.AppSettings["ApiKey"]));

            var fromTask = FromTask.Get(context);
            var toTask = ToTask.Get(context);

            var redlines = fromTask.GetRedlines(client).GetContentAsync().Result.ToList();
            Console.WriteLine("Task {0} has {1} redlines", fromTask.ID, redlines.Count());
            foreach (var redline in redlines)
            {
                redline.TaskID = toTask.ID;
                redline.ID = Guid.NewGuid();
                Console.WriteLine("Adding redline to task {0}", toTask.ID);
                var createdRedline = client.Redlines.Create(redline).GetContentAsync().Result;
                Console.WriteLine("Created a redline with id: {0} for task {1}", createdRedline.ID, toTask.ID);
            }

            toTask = client.Tasks.Get(toTask.ID).GetContentAsync().Result;

            ToTask.Set(context, toTask);

        }
    }
}
