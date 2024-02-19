using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_DSPS1A
{
    public class Customer : Person
    {
        private string Email { get; set; }
        private string Phone { get; set; }

        public Customer(string name, char gender, DateOnly birthday, string email,
            string phone) : base(name, gender, birthday)
        {
            Email = email;
            Phone = phone;
        }

        public override string ToString()
        {
            return $"CUSTOMER: {Name} - {Gender} - {Birthday} - {Email} - {Phone}";
        }


    }
}