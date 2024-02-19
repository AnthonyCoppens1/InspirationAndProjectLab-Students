using System;

namespace Bookstore_DSPS1A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookStore BestBooks = new BookStore("BestBooks", "Mechelen");
            
            Person Anthony = new Person("Anthony Coppens", 'M', new DateOnly(1995, 07, 31));
            Person John = new Person();

            Console.WriteLine(John);
            Console.WriteLine(Anthony);

            Customer Vincent = new Customer("Vincent Dupont", 'M', new DateOnly(2001, 06, 29), "VincentDupont@gmail.com", "+324789216");
            Console.WriteLine(Vincent);
            Customer Mark = new Customer("Mark Zuckerberg", 'M', new DateOnly(1980, 03, 24),
                "zuckingMark@yahoo.com", "03675321");

            Staff Elon = new Staff("Elon Muskie", 'M', new DateOnly(1978, 12, 03),
                Position.BigBoss, 1260.03);
            Staff Michael = new Staff("Michael Scott", 'M', new DateOnly(1960, 12, 03),
                Position.SmallBoss, 3428.62);

            Console.WriteLine(Michael);

            Book HPPS = new Book("Harry Potter and the Philosopher's stone", "J.K. Rowlings",
                Genre.Adventure, 6.99, 30);
            Book TheLionKing = new Book("The Lion King", "Justine Korman", Genre.Thriller, 4.20, 2);

            Console.WriteLine(HPPS);
            
            BestBooks.AddBook(HPPS);
            BestBooks.AddBook(TheLionKing);
            BestBooks.AddPerson(Michael);
            BestBooks.AddPerson(Mark);
            BestBooks.AddPerson(Vincent);
            BestBooks.AddPerson(Elon);
            Console.WriteLine();
            Console.WriteLine(BestBooks);
        }
    }
}