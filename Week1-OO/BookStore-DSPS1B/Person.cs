using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_DSPS1B
{
    public class Person
    {
        public string Name { get; set; }
        public DateOnly Birthday { get; set; }
        public char Gender { get; set; }

        public Person()
        {
            Name = "Mike Smith";
            Birthday = new DateOnly(1999, 01, 02);
            Gender = 'M';
        }

        public Person(string name, DateOnly birthday, char gender)
        {
            Name = name;
            Birthday = birthday;
            Gender = gender;
        }
        
        public override string ToString()
        {
            return Name + " - " + Birthday + " - " + Gender;
        }
    }
}
