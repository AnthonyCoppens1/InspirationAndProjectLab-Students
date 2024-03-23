using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Hospital
    {
        public string Name { get; set; }

        public int ID { get; set; }
        public List<Person> People { get; set; }

        private Data data = new Data();

        public Hospital(string name)
        {
            Name = name;
            ID = data.InsertHospital(this);
        }

        public Hospital(string name, List<Person> people)
        {
            Name = name;
            ID = data.InsertHospital(this, people);
        }

        public Hospital(int id, string name, List<Person> people)
        {
            Name = name;
            ID = id;
            People = people;
        }

        public void AddPerson(Person person)
        {
            data.AddPeopleToHospital(person.ID, this.ID);
        }

        public List<Patient> GetPatients()
        {
            return data.SelectPatients(this.ID);
        }


        public List<Person> GetStaff()
        {
            return data.SelectStaff(this.ID);
        }

        public override string ToString()
        {
            string s = "HOSPITAL " + Name + "\n";
            s += "--- PATIENTS\n";
            foreach (Person person in GetPatients())
            {
                s += "*" + person + "\n";
            }
            s += "--- STAFF\n";
            foreach (Person person in GetStaff())
            {
                s += "*" + person + "\n";
            }
            return s;
        }
    }
}
