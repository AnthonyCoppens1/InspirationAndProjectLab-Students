using System;

namespace BookStore_DSPS1B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Mike = new Person();
            Person Anthony = new Person("Anthony Coppens", new DateOnly(1995, 07, 31), 'M');

            Console.WriteLine(Anthony);

            Customer Vicente = new Customer("Vicente Espi", new DateOnly(2005, 05, 24),
                'M', "vicenteespi@gmail.com");
            Console.WriteLine(Vicente);

            Staff Cali = new Staff("Cali", new DateOnly(2000, 03, 16), 'F', Position.BigBoss);

            Console.WriteLine(Cali.Job);

        }
    }
}