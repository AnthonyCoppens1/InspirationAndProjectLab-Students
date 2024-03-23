using System;
using System.Numerics;

namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient Anthony = new Patient(1,"Anthony", new DateOnly(1995, 07, 31), "Teacher Syndrome","None");
            Doctor Jenny = new Doctor(2, "Jenny", new DateOnly(1970, 1, 1), "Heart");
            Patient Elke = new Patient(3, "Elke", new DateOnly(1980, 4, 23), "Teacher Syndrome", "None");
            Patient Collin = new Patient(4, "Collin", new DateOnly(1991, 3, 16), "FullStackDev Syndrome", "None");
            Nurse Josh = new Nurse(5, "Josh", new DateOnly(2000, 1, 1), Area.Emergency);
            Person John = new Person();


            Console.WriteLine(Anthony);
            Console.WriteLine(Elke);
            Console.WriteLine(Collin);
            Console.WriteLine(Jenny);


            List<Person> people = new List<Person>();
            people.Add(Anthony);
            people.Add(Elke);
            people.Add(Collin);
            people.Add(John);
            people.Add(Jenny);
            people.Add(Josh);

            Hospital hospital = new Hospital(1, "AZ Sint-Maarten", people);
            Doctor bea = new Doctor(6, "Bea", new DateOnly(1960, 1, 1), "Dermatology");
            hospital.AddPerson(bea);

            Console.WriteLine(hospital);

        }
    }
}