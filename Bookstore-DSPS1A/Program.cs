using System;

namespace Bookstore_DSPS1A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Anthony = new Person("Anthony Coppens", 'M', new DateOnly(1995, 07, 31));
            Person John = new Person();

            Console.WriteLine(John);
            Console.WriteLine(Anthony);

            Customer Vincent = new Customer("Vincent Dupont", 'M', new DateOnly(2001, 06, 29), "VincentDupont@gmail.com", "+324789216");
            Console.WriteLine(Vincent);

            Staff Michael = new Staff("Michael Scott", 'M', new DateOnly(1960, 12, 03),
                Position.SmallBoss, 3428.62);

            Console.WriteLine(Michael);
            
        }
    }
}