using AccountApplication.SampleDataModel;
using SQLite.CodeFirst;
namespace SampleDataModel
{
    public class AccCharts:IEntity
    {
        [Autoincrement]
        public int Id { get; set; }
        public int aref { get; set; }
        public string aChinaCode { get; set; }
        public string aHKCode { get; set; }
        public string aMrCode { get; set; }
        public string aName { get; set; }
        public string aHKName { get; set; }
        public string aMrName { get; set; }
        public string aDeptCode { get; set; }
        public string aLedger { get; set; }
        public string aType { get; set; }
        public int aLevel { get; set; }
        public string aParenet { get; set; }
        public string aGroup { get; set; }
        public string aComp { get; set; }
        public int aParentRef { get; set; }
        public string aAccType { get; set; }
    }
}