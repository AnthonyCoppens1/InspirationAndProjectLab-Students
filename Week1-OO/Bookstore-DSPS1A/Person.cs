using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_DSPS1A
{
    public class Person
    {
        public string Name { get; set; }
        public char Gender { get; set; }
        protected DateOnly Birthday { get; set; }

        public Person(string name, char gender, DateOnly birthday)
        {
            Name = name;
            Gender = gender;
            Birthday = birthday;
        }

        public Person()
        {
            Name = "John Doe";
            Gender = 'X';
            Birthday = new DateOnly(2000,01,01);
        }

        public override string ToString()
        {
            return $"{Name} - {Gender} - {Birthday}";
        }
    }
}
