using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesEngCustomOrbitActivities
{
    public abstract class TraceResultBase
    {
        public string FacilityID { get; set; }
        public Guid GUID { get; set; }
        public double Latitude{get; set;}
        public double Longitude{get; set;}
    }
}
