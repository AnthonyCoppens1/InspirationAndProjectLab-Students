using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Data
    {
        private string connectionString = "datasource=127.0.0.1; port=3306; username = root; password=; database=hospital;";

        private const int _patient = 1;
        private const int _nurse = 2;
        private const int _doctor = 3;

        private int Insert(string query)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                int result = commandDatabase.ExecuteNonQuery();
                return (int)commandDatabase.LastInsertedId;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return -1;
        }

        public int InsertPatient(Patient patient)
        {
            string query = $"INSERT INTO person(ID,Name,Birth,Type,Problem,Treatment)" +
                $"VALUES (NULL, '{patient.Name}', '{patient.Birth.ToString("yyyy-MM-dd")}'," +
                $"{_patient}, '{patient.Problem}','{patient.Treatment}');";

            return this.Insert(query);
        }

        public int InsertNurse(Nurse nurse)
        {
            string query = $"INSERT INTO person(ID,Name,Birth,Type,Area)" +
                $"VALUES (NULL, '{nurse.Name}', '{nurse.Birth.ToString("yyyy-MM-dd")}'," +
                $"{_nurse}, '{nurse.Department}');";

            return this.Insert(query);
        }

        public int InsertDoctor(Doctor doctor)
        {
            string query = $"INSERT INTO person(ID,Name,Birth,Type,Specialty)" +
                $"VALUES (NULL, '{doctor.Name}', '{doctor.Birth.ToString("yyyy-MM-dd")}'," +
                $"{_doctor}, '{doctor.Specialty}');";

            return this.Insert(query);
        }

        public int InsertHospital(Hospital hospital)
        {
            Console.WriteLine(hospital.Name);
            string query = $"INSERT INTO hospital(ID, Name) " +
                $"VALUES (NULL, '{hospital.Name}');";

            return this.Insert(query);
        }

        public int InsertHospital(Hospital hospital, List<Person> people)
        {
            int id = InsertHospital(hospital);
            foreach (var person in people)
            {
                AddPeopleToHospital(person.ID, id);
            }
            return id;
        }

        public void AddPeopleToHospital(int personID, int hospitalID)
        {
            string query = $"INSERT INTO peopleinhospital(Person,Hospital) " +
                $"VALUES ('{personID}','{hospitalID}');";
            Insert(query);
        }
    }
}
