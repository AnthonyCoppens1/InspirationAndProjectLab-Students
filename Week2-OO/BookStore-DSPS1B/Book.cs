using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_DSPS1B
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public Genre Category { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public Book(string title, string author, Genre category, double price, int stock)
        {
            Title = title;
            Author = author;
            Category = category;
            Price = price;
            Stock = stock;
        }

        public override string ToString()
        {
            return $"Book: {Title} - {Author} - {Category} - $ {Price} - Stock: {Stock}";
        }
    }

    public enum Genre
    {
        Thriller,
        Comedy,
        Fantasy,
        SciFi,
        NonFiction,
        Romance,
        Horror,
        Romcom,
        Religious,
        Drama,
        Documentary,
        Biography,
        Comic,
        GraphicNovel,
        Crime,
        Action,
        Adventure,
        Cookbooks,
        Magazines,
        Newspaper,
        Fashion,
        Travel,
        Guides,
        History,
        Dictionary,
        Calender,
        Academic
    }
}
