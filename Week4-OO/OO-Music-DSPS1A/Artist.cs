using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Music_DSPS1A
{
    public class Artist
    {
        public string Name { get; set; }
        public Genres Genre { get; set; }
        public int AlbumCount { get; private set; }

        public Artist(string name, Genres genre)
        {
            Name = name;
            Genre = genre;
            AlbumCount = 0;
        }

        public void AddAlbum()
        {
            AlbumCount++;
        }

        public void RemoveAlbum()
        {
            if (AlbumCount > 0)
            {
                AlbumCount--;
            }
        }

        public override string ToString()
        {
            return $"{Name} - {Genre} - Albums: {AlbumCount}";
        }

    }
}
