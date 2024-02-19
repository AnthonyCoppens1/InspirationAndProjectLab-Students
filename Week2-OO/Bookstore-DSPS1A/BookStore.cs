using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_DSPS1A
{
    public class BookStore
    {
        protected int TotalStock { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        private List<Book> Inventory { get; set; }
        private List<Person> People { get; set; }

        //First constructor to add the new bookstore the the system of bookstores
        public BookStore(string name, string city)
        {
            Name = name;
            City = city;
            Inventory = new List<Book>();
            People = new List<Person>();
        }

        //Second constructor to be able to update the system
        public BookStore(int totalstock, string name, string city, List<Book> inventory,
            List<Person> people)
        {
            TotalStock = totalstock;
            Name = name;
            City = city;
            Inventory = inventory;
            People = people;
        }

       
        public void AddBook(Book book)
        {
            Inventory.Add(book);
            TotalStock += book.Stock;
        }

        public void RemoveBook(Book book)
        {
            Inventory.Remove(book);
        }

        public void AddPerson(Person person)
        {
            People.Add(person);
        }

        public List<Customer> GetCustomer()
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
            string s = $"Bookstore {Name} in {City}\n";
            s += $"Inventory count: {TotalStock}\n";
            s += $"Inventory unique books: {Inventory.Count}\n";

            foreach (var book in Inventory)
            {
                s += $"* {book}\n";
            }

            var customers = GetCustomer();
            s += $"Customer count: {customers.Count}\n";
            foreach (var customer in customers)
            {
                s += $"* {customer.Name}\n";
            }

            var staff = GetStaff();
            s += $"Staff count: {staff.Count}\n";
            foreach (var staffmember in staff)
            {
                s += $"* {staffmember.Name} - {staffmember.Job}\n";
            }

            return s.ToString();
        }


    }
}
