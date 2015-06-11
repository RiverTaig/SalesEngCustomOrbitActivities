using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestConsole
{
    public class FieldAliases
    {
        public string OBJECTID { get; set; }
        public string ANCILLARYROLE { get; set; }
        public string ENABLED { get; set; }
        public string CREATIONUSER { get; set; }
        public string DATECREATED { get; set; }
        public string DATEMODIFIED { get; set; }
        public string LASTUSER { get; set; }
        public string LEGACYID { get; set; }
        public string INSTALLATIONDATE { get; set; }
        public string PIPENAME { get; set; }
        public string STATION { get; set; }
        public string STATUS { get; set; }
        public string SUBTYPECD { get; set; }
        public string DIAMETER { get; set; }
        public string MATERIAL { get; set; }
        public string OWNER { get; set; }
        public string MANUFACTURER { get; set; }
        public string WORKORDERID { get; set; }
        public string PROJECTNUMBER { get; set; }
        public string INSERVICEDATE { get; set; }
        public string PROPERTYUNITCODE { get; set; }
        public string WORKMANAGEMENTSYSTEMCODE { get; set; }
        public string GASTRACEWEIGHT { get; set; }
        public string SYMBOLROTATION { get; set; }
        public string BONDEDINDICATOR { get; set; }
        public string INSULATEDINDICATOR { get; set; }
        public string STYLE { get; set; }
        public string CLEDITRESPONSE { get; set; }
        public string CLVALIDITYTOLERANCE { get; set; }
        public string PRESSURERATING { get; set; }
        public string EMERISOLATIONSYSSTATUS { get; set; }
        public string GASPRESSURESYSTEMSTATUS { get; set; }
        public string GASSYSTEMSTATUS { get; set; }
        public string NORMALPOSITION { get; set; }
        public string WORKREQUESTID { get; set; }
        public string DESIGNID { get; set; }
        public string WORKLOCATIONID { get; set; }
        public string WORKFLOWSTATUS { get; set; }
        public string WORKFUNCTION { get; set; }
        public string SE_ANNO_CAD_DATA { get; set; }
        public string GlobalID { get; set; }
        public string FACILITYID { get; set; }
        public string PREMISE { get; set; }
        public string BYPASSINDICATOR { get; set; }
        public string LOCATIONDESCRIPTION { get; set; }
        public string LOCATIONID { get; set; }
        public string SubtypeCD { get; set; }
        public string OPERATINGSTATUS { get; set; }
        public string COMMENTS { get; set; }
        public string QUANTITY { get; set; }
        public string WEIGHT { get; set; }
        public string CPRECTIFIERCABLEOBJECTID { get; set; }
        public string CPSYSTEMOBJECTID { get; set; }
        public string EQUIPMENTID { get; set; }
        public string VALVETYPE { get; set; }
        public string VALVEUSE { get; set; }
        public string ANSIPRESSURERATING { get; set; }
        public string CLOCKWISETOCLOSE { get; set; }
        public string DEPTH { get; set; }
        public string DEPTHTONUT { get; set; }
        public string GROUNDLEVELINDICATOR { get; set; }
        public string PRESENTPOSITION { get; set; }
        public string OPERATINGCLASSIFICATION { get; set; }
        public string TURNSTOCLOSE { get; set; }
        public string DIMENSIONTIE1 { get; set; }
        public string DIMENSIONTIE2 { get; set; }
        public string MODEL { get; set; }
        public string EMERISOLATIONSYSOBJECTID { get; set; }
        public string GASPRESSURESYSTEMOBJECTID { get; set; }
        public string GASSYSTEMOBJECTID { get; set; }
        public string CPSYSTEMSTATUS { get; set; }
        public string Subdivision { get; set; }
        public string County { get; set; }
        public string State { get; set; }
        public string CAPACITYCFH { get; set; }
        public string AMPERAGE { get; set; }
        public string COOLINGMETHOD { get; set; }
        public string INTERNALMETER { get; set; }
        public string RECTIFIERTYPE { get; set; }
        public string VOLTAGE { get; set; }
        public string SERIALNUMBER { get; set; }
        public string NAME { get; set; }
        public string TESTPOINTTYPE { get; set; }
        public string WIRECOUNT { get; set; }
        public string NEXTTESTDATE { get; set; }
        public string FacilityID { get; set; }
    }

    public class SpatialReference
    {
        public int wkid { get; set; }
        public int latestWkid { get; set; }
    }

    public class Field
    {
        public string name { get; set; }
        public string type { get; set; }
        public string alias { get; set; }
        public int? length { get; set; }
    }

    public class Attributes
    {
        public int OBJECTID { get; set; }
        public int? ANCILLARYROLE { get; set; }
        public int ENABLED { get; set; }
        public string CREATIONUSER { get; set; }
        public object DATECREATED { get; set; }
        public object DATEMODIFIED { get; set; }
        public string LASTUSER { get; set; }
        public string LEGACYID { get; set; }
        public object INSTALLATIONDATE { get; set; }
        public object PIPENAME { get; set; }
        public object STATION { get; set; }
        public string STATUS { get; set; }
        public int SUBTYPECD { get; set; }
        public object DIAMETER { get; set; }
        public string MATERIAL { get; set; }
        public string OWNER { get; set; }
        public string MANUFACTURER { get; set; }
        public object WORKORDERID { get; set; }
        public object PROJECTNUMBER { get; set; }
        public long? INSERVICEDATE { get; set; }
        public object PROPERTYUNITCODE { get; set; }
        public object WORKMANAGEMENTSYSTEMCODE { get; set; }
        public int GASTRACEWEIGHT { get; set; }
        public double? SYMBOLROTATION { get; set; }
        public object BONDEDINDICATOR { get; set; }
        public object INSULATEDINDICATOR { get; set; }
        public string STYLE { get; set; }
        public string CLEDITRESPONSE { get; set; }
        public object CLVALIDITYTOLERANCE { get; set; }
        public object PRESSURERATING { get; set; }
        public string EMERISOLATIONSYSSTATUS { get; set; }
        public object GASPRESSURESYSTEMSTATUS { get; set; }
        public object GASSYSTEMSTATUS { get; set; }
        public int NORMALPOSITION { get; set; }
        public object WORKREQUESTID { get; set; }
        public object DESIGNID { get; set; }
        public object WORKLOCATIONID { get; set; }
        public int? WORKFLOWSTATUS { get; set; }
        public int? WORKFUNCTION { get; set; }
        public object SE_ANNO_CAD_DATA { get; set; }
        public string GlobalID { get; set; }
        public string FACILITYID { get; set; }
        public object PREMISE { get; set; }
        public object BYPASSINDICATOR { get; set; }
        public string LOCATIONDESCRIPTION { get; set; }
        public int? LOCATIONID { get; set; }
        public int? SubtypeCD { get; set; }
        public string OPERATINGSTATUS { get; set; }
        public string COMMENTS { get; set; }
        public string QUANTITY { get; set; }
        public string WEIGHT { get; set; }
        public object CPRECTIFIERCABLEOBJECTID { get; set; }
        public object CPSYSTEMOBJECTID { get; set; }
        public object EQUIPMENTID { get; set; }
        public string VALVETYPE { get; set; }
        public string VALVEUSE { get; set; }
        public object ANSIPRESSURERATING { get; set; }
        public object CLOCKWISETOCLOSE { get; set; }
        public object DEPTH { get; set; }
        public object DEPTHTONUT { get; set; }
        public object GROUNDLEVELINDICATOR { get; set; }
        public object PRESENTPOSITION { get; set; }
        public string OPERATINGCLASSIFICATION { get; set; }
        public object TURNSTOCLOSE { get; set; }
        public object DIMENSIONTIE1 { get; set; }
        public object DIMENSIONTIE2 { get; set; }
        public string MODEL { get; set; }
        public object EMERISOLATIONSYSOBJECTID { get; set; }
        public object GASPRESSURESYSTEMOBJECTID { get; set; }
        public object GASSYSTEMOBJECTID { get; set; }
        public object CPSYSTEMSTATUS { get; set; }
        public object Subdivision { get; set; }
        public object County { get; set; }
        public object State { get; set; }
        public object CAPACITYCFH { get; set; }
        public string AMPERAGE { get; set; }
        public object COOLINGMETHOD { get; set; }
        public object INTERNALMETER { get; set; }
        public object RECTIFIERTYPE { get; set; }
        public int? VOLTAGE { get; set; }
        public object SERIALNUMBER { get; set; }
        public object NAME { get; set; }
        public string TESTPOINTTYPE { get; set; }
        public string WIRECOUNT { get; set; }
        public long? NEXTTESTDATE { get; set; }
        public string FacilityID { get; set; }
    }

    public class Geometry
    {
        public double x { get; set; }
        public double y { get; set; }
    }

    public class Feature
    {
        public Attributes attributes { get; set; }
        public Geometry geometry { get; set; }
    }

    public class Result
    {
        public string displayFieldName { get; set; }
        public FieldAliases fieldAliases { get; set; }
        public string geometryType { get; set; }
        public SpatialReference spatialReference { get; set; }
        public List<Field> fields { get; set; }
        public List<Feature> features { get; set; }
        public string name { get; set; }
        public int id { get; set; }
        public bool exceededThreshold { get; set; }
    }

    public class RootObject
    {
        public List<Result> results { get; set; }
    }
}
