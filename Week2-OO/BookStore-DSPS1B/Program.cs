using System;

namespace BookStore_DSPS1B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookStore BestBooks = new BookStore("BestBooks", "Mechelen");
            Person Mike = new Person();
            Person Anthony = new Person("Anthony Coppens", new DateOnly(1995, 07, 31), 'M');

            Console.WriteLine(Anthony);
            Console.WriteLine();

            Customer Vicente = new Customer("Vicente Espi", new DateOnly(2005, 05, 24),
                'M', "vicenteespi@gmail.com", "045672135");
            Console.WriteLine(Vicente);
            
            Console.WriteLine();
            Staff Cali = new Staff("Cali", new DateOnly(2000, 03, 16), 'F', Position.BigBoss);

            Console.WriteLine(Cali.Job);
            Console.WriteLine();

            Book HPPS = new Book("Harry Potter and the Philosopher's stone", "J.K. Rowling",
                Genre.Fantasy, 15.99, 20);

            Book TheLionKing = new Book("The Lion King", "Justine Korman", Genre.Adventure, 4.99, 12);

            Customer JJ = new Customer("JJ", new DateOnly(1960,12,2),'M',"JJ@Yahoo.com", "23479823947");


            Console.WriteLine(HPPS);
            Console.WriteLine();

            BestBooks.AddBook(HPPS);
            BestBooks.AddBook(TheLionKing);
            BestBooks.AddPerson(Vicente);
            BestBooks.AddPerson(Cali);
            BestBooks.AddPerson(JJ);
            Console.WriteLine(BestBooks);

            

        }
    }
}