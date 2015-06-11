using System;
using System.Activities;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesEngCustomOrbitActivities
{
    public class CreateFile : CodeActivity
    {
        [RequiredArgument]
        public InArgument<string> FileName { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            string path = FileName.Get(context);

            Console.WriteLine(Path.GetFullPath(path));

            File.Create(path);
        }
    }
}
