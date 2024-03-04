using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Music_DSPS1B
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
        } //basic existence of playlist

        public PlayList(string name, List<Song> songs)
        {
            Name = name;
            Songs = songs;
            Length = 0;

            foreach (var item  in Songs) // Song S in Songs
            {
                Length += item.Length;
            }
        }

        public void AddSong(Song S)
        {
            Songs.Add(S);
            Length += S.Length;
        }
        public void RemoveSong(Song S)
        {
            Songs.Remove(S);
            Length -= S.Length;
        }

        public void Play()
        {
            foreach(Song S in Songs)
            {
                S.Play();
            }
        }

        public void Shuffle()
        {
            Random rd = new Random();
            for (int i = Songs.Count-1; i >= 0; i--)
            {
                int nr = rd.Next(0, i + 1);
                Song temp = Songs[nr];
                Songs[nr] = Songs[i];
                Songs[i] = temp;
            }
        }

        public override string ToString()
        {
            string s = $"\n{Name} - Length: {Length}\n";
            foreach (Song song in Songs)
            {
                s += "*" + song + "\n";
            }
            return s;
        }
    }
}
