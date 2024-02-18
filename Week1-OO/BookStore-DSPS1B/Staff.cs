using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_DSPS1B
{
    public class Staff : Person
    {
        public Position Job { get; set; }

        public Staff(string name, DateOnly birthday, char gender,
            Position job) : base(name, birthday, gender)
        {
            Job = job;
        }

        public override string ToString()
        {
            return $"Staff: {Name} - {Birthday} - {Gender} - {Job}"; 
        }
    }


}
