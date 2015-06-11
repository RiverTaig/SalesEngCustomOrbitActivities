using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesEngCustomOrbitActivities
{
    public class TraceResult
    {
        public TraceResult()
        {
            TestPoints = new List<TestPoint>();
            Rectifiers = new List<Rectifier>();
            Anodes = new List<Anode>();
        }
        public List<TestPoint> TestPoints { get; set; }
        public List<Rectifier> Rectifiers { get; set; }
        public List<Anode> Anodes { get; set; }
    }
}
