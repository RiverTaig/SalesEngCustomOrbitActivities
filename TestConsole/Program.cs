using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Newtonsoft.Json;
using SalesEngCustomOrbitActivities;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            double lat = 49.0;
            double lon = -114.25;
            double x =0; double y = 0;
            ToWebMercatorAuxSphere(lat, lon, out x, out y);

            var TraceResult = DoTrace();

        }
        private static void ToWebMercatorAuxSphere(double lat, double lng, out double x_merc, out double y_merc)
        {
            x_merc = 0;
            y_merc = 0;
            if (lng <= 180 && lat < 90)
            {
                double num = lng * .017453292519943295;
                double x = 6378137.0 * num;
                double a = lat * .017453292519943295;
                x_merc = x;
                y_merc = 3189068.5 * Math.Log((1.0 + Math.Sin(a)) / (1.0 - Math.Sin(a)));
            }
        }
        private static void ToGeographic(ref double mercatorX_lon, ref double mercatorY_lat)
        {
            if (Math.Abs(mercatorX_lon) < 180 && Math.Abs(mercatorY_lat) < 90)
                return;

            if ((Math.Abs(mercatorX_lon) > 20037508.3427892) || (Math.Abs(mercatorY_lat) > 20037508.3427892))
                return;

            double x = mercatorX_lon;
            double y = mercatorY_lat;
            double num3 = x / 6378137.0;
            double num4 = num3 * 57.295779513082323;
            double num5 = Math.Floor((double)((num4 + 180.0) / 360.0));
            double num6 = num4 - (num5 * 360.0);
            double num7 = 1.5707963267948966 - (2.0 * Math.Atan(Math.Exp((-1.0 * y) / 6378137.0)));
            mercatorX_lon = num6;
            mercatorY_lat = num7 * 57.295779513082323;
        }
        static TraceResult DoTrace()
        {
            try
            {

                string json;
                RootObject o;
                CallArcFMServerTrace(out json, out o);
                List<TraceResultBase> rectifiers = new List<TraceResultBase>();
                List<TraceResultBase> anodes = new List<TraceResultBase>();
                List<TraceResultBase> testPoints = new List<TraceResultBase>();
                Dictionary<string,List<TraceResultBase>> traceFeatureLists = new Dictionary<string,List<TraceResultBase>>{
                    {"CP Anode", anodes},
                    {"CP Test Point", testPoints},
                    {"CP Rectifier", rectifiers}
                };
                if (o is RootObject)
                {
                    foreach (var x in o.results)
                    {
                        string name = x.name;
                        if (name == "CP Anode" || name == "CP Test Point" || name == "CP Rectifier")
                        {
                            List<TraceResultBase> activeList = traceFeatureLists[name];
                            foreach (var fe in x.features)
                            {
                                string guid = fe.attributes.GlobalID;
                                string facilityID = fe.attributes.FACILITYID ?? fe.attributes.FacilityID;
                                double xCoord =  fe.geometry.x;
                                double yCoord =  fe.geometry.y;

                                ToGeographic(ref xCoord, ref yCoord);
                                TraceResultBase traceResultFe = null;
                                switch (name)
                                {
                                    case "CP Test Point":
                                        traceResultFe = new TestPoint();
                                        ((TestPoint) traceResultFe).LegacyID = fe.attributes.LEGACYID;
                                        break;
                                    case "CP Rectifier":
                                        traceResultFe = new Rectifier();
                                        break;
                                    case "CP Anode":
                                        traceResultFe = new Anode();
                                        break;
                                }
                                traceResultFe.FacilityID = facilityID;
                                traceResultFe.Latitude = yCoord;
                                traceResultFe.Longitude = xCoord;
                                if (guid != null)
                                {
                                    traceResultFe.GUID = new Guid(guid);
                                }
                                activeList.Add(traceResultFe);
                            }

                            
                            Anode a = new Anode();
                            anodes.Add(a);
                        }
                    }
                }
                TraceResult result = new TraceResult();
                //result.Rectifiers = rectifiers;
                //result.Anodes = anodes;
                //result.TestPoints = testPoints;
                return result;
            }
            catch(Exception ex)
            {
                //Console.WriteLine(ex.ToString());
                return null;
            }
            finally{
                //Console.ReadLine();
            }

        }
        private static void CallArcFMServerTrace(out string json, out RootObject o)
        {
            string servicesDirectory = "http://63.253.242.156/arcgis/rest/services/";
            //string servicesDirectory = "http://mira:6080/arcgis/rest/services/";
            string startPoint = "-9161899.08617426%2C3459745.87070476";
            //string extension = "Schneiderville/GasDistribution/MapServer/exts/ArcFMMapServer/Gas%20Trace?";
            string extension = "ArcFM_Silverlight_Schneiderville/Gas/MapServer/exts/ArcFMMapServer/Gas%20Trace?";
            string traceType = "CathodicProtection";
            string isolationTraceBarriers = "";
            string excludedValves = "";
            string includedValves = "";
            string squeezeOffs = "";
            string temporarySources = "";
            string pressureSystemTraceBarriers = "";
            string systemTraceBarriers = "";
            string drawComplexEdges = "";
            string includeEdges = "";
            string includeJunctions = "True";
            string returnAttributes = "True";
            string returnGeometries = "True";
            string tolerance = "";
            string spatialReference = "{WKID%3A102100}";
            string f = "pjson";
            string url = servicesDirectory +
                extension +
                "startPoint=" + startPoint +
                "&traceType=" + traceType +
                "&isolationTraceBarriers=" + isolationTraceBarriers +
                "&excludedValves=" + excludedValves +
                "&includedValves=" + includedValves +
                "&squeezeOffs=" + squeezeOffs +
                "&temporarySources=" + temporarySources +
                "&pressureSystemTraceBarriers=" + pressureSystemTraceBarriers +
                "&systemTraceBarriers=" + systemTraceBarriers +
                "&drawComplexEdges=" + drawComplexEdges +
                "&includeEdges=" + includeEdges +
                "&includeJunctions=" + includeJunctions +
                "&returnAttributes=" + returnAttributes +
                "&returnGeometries=" + returnGeometries +
                "&tolerance=10" + tolerance +
                "&spatialReference=" + spatialReference +
                "&f=" + f;
            WebClient client = new WebClient();
            json = client.DownloadString(url);
            o = JsonConvert.DeserializeObject<RootObject>(json);
        }

    }
}
