using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_DSPS1B
{
    public class BookStore
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int TotalCount { get; set; }
        public List<Person> People { get; set; }
        public List<Book> Inventory { get; set; }

        public BookStore(string name, string location)
        {
            Name = name;
            Location = location;
            Inventory = new List<Book>();
            People = new List<Person>();
        }

        public BookStore(string name, string location, int totalcount,
            List<Book> inventory, List<Person> people)
        {
            Name = name;
            Location = location;
            TotalCount = totalcount;
            Inventory = inventory;
            People = people;
        }

        public void AddBook(Book book)
        {
            Inventory.Add(book);
            TotalCount += book.Stock;
        }

        public void AddPerson(Person person)
        {
            People.Add(person);
        }

        public void RemovePerson(Person person)
        {
            People.Remove(person);
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            foreach (Person person in People)
            {
                if (person is Customer)
                {
                    customers.Add((Customer)person);
                }
            }
            return customers;
        }

        public List<Staff> GetStaff()
        {
            List<Staff> staffmembers = new List<Staff>();
            foreach (Person person in People)
            {
                if (person is Staff)
                {
                    staffmembers.Add((Staff)person);
                }
            }
            return staffmembers;
        }

        public override string ToString()
        {
            string s = $"Bookstore: {Name} in {Location}\n";
            s += $"TotalInventory count: {TotalCount}\n";
            s += $"Inventory count of unique books: {Inventory.Count}\n";
            
            foreach (var book in Inventory)
            {
                s += $"* {book}\n";
            }

            var customers = GetCustomers();
            s += $"Customer count: {customers.Count}\n";

            foreach (var customer in customers)
            {
                s += $"* {customer.Name} {customer.Email}\n";
            }

            var staff = GetStaff();
            s += $"Staff count: {staff.Count}\n";

            foreach (var S in staff)
            {
                s += $"* {S.Name} - {S.Job}\n";
            }
            return s;
        }
    }
}
