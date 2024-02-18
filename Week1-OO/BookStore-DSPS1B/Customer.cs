using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_DSPS1B
{
    public class Customer : Person
    {
        public string Email { get; set; }
        public Customer(string name, DateOnly birthday, char gender, string email) : base(name, birthday, gender)
        {
            Email = email; 
        }

        public override string ToString()
        {
            return $"CUSTOMER: {Name} - {Birthday} - {Gender} - {Email}";
        }

    }
}
