using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hospital
{
    public class Nurse : Person
    {
        public Area Department { get; set; }

        private Data data = new Data();

        public Nurse(string name, DateOnly birth, Area department) : base(name, birth)
        {
            Department = department;
            ID = data.InsertNurse(this);
        }

        public Nurse(int id, string name, DateOnly birth, Area department) : base(id, name, birth)
        {
            Department = department;
            ID = id;
        }

        public override string ToString()
        {
            return $"NURSE: {Name} - {Birth} - {Department}";
        }
    }
}
