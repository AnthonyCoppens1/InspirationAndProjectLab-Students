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

        public void AddPerson(Person person)
        {
            data.AddPeopleToHospital(person.ID, this.ID);
        }

        /*public List<Patient> GetPatients()
        {
            List<Patient> patients = new List<Patient>();
            foreach (Person person in People)
            {
                if (person is Patient)
                {
                    patients.Add((Patient)person);
                }
            }//every individual inside of the original list
            return patients;
        }


        public List<Person> GetStaff()
        {
            List<Person> staff = new List<Person>();
            foreach (Person person in People)
            {
                if (person is Doctor || person is Nurse)
                {
                    staff.Add(person);
                }
            }
            return staff;
        }

        public override string ToString()
        {
            string s = "HOSPITAL " + Name + "\n";
            foreach (Person person in People)
            {
                s += " - " + person + "\n";
            }
            return s;
        }*/
    }
}
