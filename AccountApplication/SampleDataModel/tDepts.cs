using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApplication.SampleDataModel
{
    public class tDepts : IEntity
    {
        [Autoincrement]
        public int Id { get; set; }
        public string xDeptCode { get; set; }
        public string xFullName { get; set; }
        public int xOrd { get; set; }
        public string xDelFlag { get; set; }
    }
}
