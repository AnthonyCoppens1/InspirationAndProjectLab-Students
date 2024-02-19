using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_DSPS1A
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public Genre BookGenre { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public Book(string title, string author, Genre bookgenre, double price,
            int stock)
        {
            Title = title;
            Author = author;
            BookGenre = bookgenre;
            Price = price;
            Stock = stock;
        }

        public override string ToString()
        {
            return $"Book: {Title} - {Author} - {BookGenre} - $ {Price} - {Stock}";
        }

    }

    public enum Genre
    {
        Thriller,
        Adventure,
        Romance,
        Tragedy,
        SciFi,
        Comedy,
        Biography,
        Poetry,
        Documentary,
        Cooking,
        Drama,
        ColouringBook,
        Comic,
        GraphicNovel,
        Sports,
        Magazine,
        NewsPaper,
        Manual,
        Horror,
        RomCom,
        Manga,
        ForbiddenSection
    }
}
