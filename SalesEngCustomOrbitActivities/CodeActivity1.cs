using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace SalesEngCustomOrbitActivities
{

    public sealed class CodeActivity1 : CodeActivity<TraceResult>
    {
        
        // Define an activity input argument of type string
        [RequiredArgument]
        public InArgument<int> X { get; set; }
        [RequiredArgument]
        public InArgument<int> Y { get; set; }

        //public OutArgument<TraceResult> Result{get; set;}

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override TraceResult Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            int lng = X.Get(context);

            TestPoint tp = new TestPoint();
            tp.FacilityID = "CPTP4016";
            tp.Longitude = -82.303;
            tp.Latitude = 29.652;
            tp.LegacyID = "CPTP4016";

            Rectifier rect = new Rectifier();
            rect.FacilityID = "RECT1010";
            rect.Longitude = -82.303;
            rect.Latitude = 29.652;

            TraceResult tr = new TraceResult();
            tr.TestPoints.Add(tp);
            tr.Rectifiers.Add(rect);

            return tr;
        }
    }
}
