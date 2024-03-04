using System;

namespace OO_Music_DSPS1A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Artist Drake = new Artist("Drake", Genres.Rap);
            Artist Miley = new Artist("Miley Cyrus", Genres.Pop);
            Artist Eminem = new Artist("Eminem", Genres.Rap);
            Artist Billie = new Artist("Billie Eilish", Genres.Pop);
            Artist BurnaBoy = new Artist("BurnaBoy", Genres.AfroBeats);
            Artist Beatles = new Artist("Beatles", Genres.Rock);

            Drake.AddAlbum();
            Drake.AddAlbum();
            Eminem.RemoveAlbum();

            List<Artist> artists = new List<Artist>();
            artists.Add(Drake);
            artists.Add(Miley);
            artists.Add(Eminem);
            artists.Add(Billie);
            artists.Add(BurnaBoy);
            artists.Add(Beatles);

            foreach (var item in artists) //Artist A in artists
            {
                Console.WriteLine(item);
            }


            Song passionfruit = new Song("Passionfruit", Drake, Genres.Rap,1000);
            Song flower = new Song("Flowers", Miley, Genres.Pop, 2000);
            Song withoutme = new Song("Without me", Eminem, Genres.Rap, 3000);
            Song lovely = new Song("Lovely", Billie, Genres.Pop, 4000);
            Song lastlast = new Song("Last last", BurnaBoy, Genres.AfroBeats, 5000);
            Song Holdmyhand = new Song("Hold my hand", Beatles, Genres.Rock, 7000);

            List<Song> songs = new List<Song>();
            songs.Add(passionfruit); songs.Add(flower);
            songs.Add(withoutme); songs.Add(lovely);
            songs.Add(lastlast); songs.Add(Holdmyhand);

            PlayList DSPS = new PlayList("DSPS", songs);
            //DSPS.Play();
            DSPS.Shuffle();
            Console.WriteLine(DSPS);
        }
    }
}
