using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Music_DSPS1A
{
    public class PlayList
    {
        public string Name { get; set; }
        public List<Song> Songs { get; set; }
        public int Length { get; private set; }

        public PlayList(string name)
        {
            Name = name;
            Songs = new List<Song>();
            Length = 0;
        } //basic structure of playlist with nothing inside


        public PlayList(string name, List<Song> songs)
        {
            Name = name;
            Songs = songs;
            Length = 0;
            foreach (var item in Songs) //foreach (Song song in Songs)
            {
                Length += item.Length;
            }
        }

        public void AddSong(Song song)
        {
            Songs.Add(song);
            Length += song.Length;
        }

        public void RemoveSong(Song song)
        {
            Songs.Remove(song);
            Length -= song.Length;
        }

        public void Play()
        {
            foreach (var item in Songs)
            {
                item.Play();
            }
        }

        public void Shuffle()
        {
            Random rd = new Random();
            for (int i = Songs.Count-1; i >= 0; i--)
            {
                int number = rd.Next(0,i+1);
                Song temp = Songs[number];
                Songs[number] = Songs[i];
                Songs[i] = temp;
            }
        }

        public override string ToString()
        {
            string s = $"{Name} - Length: {Length}\n";
            foreach (Song S in Songs) 
            {
                s += "*" + S + "\n";
            }
            return s;
        }
    }
}
