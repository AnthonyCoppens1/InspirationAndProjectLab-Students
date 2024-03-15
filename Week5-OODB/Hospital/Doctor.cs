using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hospital
{
    public class Doctor : Person
    {
        public string Specialty { get; set; }

        private Data data = new Data();
        public Doctor(string name, DateOnly birth, string specialty) : base(name, birth)
        {
            Specialty = specialty;
            ID = data.InsertDoctor(this);
        }
        public Doctor(int id, string name, DateOnly birth, string specialty) : base(id, name, birth)
        {
            Specialty = specialty;
        }

        public override string ToString()
        {
            return $"DOCTOR: {Name} - {Birth} - {Specialty}";
        }
    }
}
