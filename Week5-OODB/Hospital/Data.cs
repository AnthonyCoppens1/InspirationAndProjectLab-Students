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

        public List<Patient> SelectPatients(int hospitalID)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            string query = $"SELECT * FROM person " +
                $"INNER JOIN peopleinhospital on person.ID = peopleinhospital.Person " +
                $"WHERE Type = '{_patient}' AND Hospital = '{hospitalID}';";

            MySqlCommand commandDatabase = new MySqlCommand(query, connection);

            List<Patient> patients = new List<Patient>();

            try
            {
                connection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["ID"];
                    string name = (string)reader["Name"];
                    DateOnly birth = DateOnly.FromDateTime((DateTime)reader["Birth"]);
                    string problem = (string)reader["Problem"];
                    string treatment = (string)reader["Treatment"];

                    patients.Add(new Patient(id, name, birth, problem, treatment));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return patients;
        }

        public List<Person> SelectStaff(int hospitalID)
        {
            MySqlConnection connection = new MySqlConnection (connectionString);
            string query = $"SELECT * FROM person " +
                $"INNER JOIN peopleinhospital on person.ID = peopleinhospital.Person " +
                $"WHERE Type != {_patient} AND Hospital = {hospitalID};";

            MySqlCommand commandDatabase = new MySqlCommand (query, connection);

            List<Person> staff = new List<Person>();

            try
            {
                connection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    if ((int)reader["Type"] == _doctor)
                    {
                        staff.Add(new Doctor((int)reader["ID"], (string)reader["Name"],
                            DateOnly.FromDateTime((DateTime)reader["Birth"]), (string)reader["Specialty"]));
                    }
                    else
                    {
                        Area area;
                        Enum.TryParse((string)reader["Area"], out area);
                        staff.Add(new Nurse((int)reader["ID"], (string)reader["Name"],
                            DateOnly.FromDateTime((DateTime)reader["Birth"]), area));
                    }
                }
                connection.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return staff;
        }

    }
}
