using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Music_DSPS1B
{
    public class Song: IComparable
    {
        public string Title { get; set; }
        public Artist Singer { get; set; }
        public Genres Genre { get; set; }
        public int Length { get; set; }

        public Song(string title, Artist singer, Genres genre, int length)
        {
            Title = title;
            Singer = singer;
            Genre = genre;
            Length = length;            
        }

        public void Play()
        {
            Console.WriteLine($"\nNow playing: {Title} by {Singer.Name}");
            for (int i = 0; i < Length / 1000; i++)
            {
                Console.Write(".");
                Console.Beep();
                Thread.Sleep(1000); //without for loop --> (7000) but no dots
            }
            Console.WriteLine($"\nFinished playing: {Title} by {Singer.Name}");
        }

        public override string ToString()
        {
            return $"{Title} - {Singer.Name} - {Genre} - {Length}";
        }

        public int CompareTo(object? obj)
        {
            if (obj is Song)
            {
                Song otherSong = (Song)obj;
                return this.Title.CompareTo(otherSong.Title);
            }
            return 0;
        }

        /*public int CompareTo(object? obj)
        {
            return this.Title.CompareTo(((Song)obj).Title);
            if (this.Title < Song.Title)
            {
                return -1;
            }
            else if (this.Title == Song.Title)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }*/
    }
}
