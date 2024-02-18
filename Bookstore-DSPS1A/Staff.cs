using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_DSPS1A
{
    public class Staff : Person
    {
        private double Salary { get; set; }
        public Position Job { get; set; }

        public Staff(string name, char gender, DateOnly birthday, Position job,
            double salary) : base(name, gender, birthday)
        {
            Job = job;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"STAFF: {Name} - {Gender} - {Birthday} - {Job} - {Salary}";
        }
    }
}
