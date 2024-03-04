using System;

namespace OO_Music_DSPS1B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Artist Justin = new Artist("Justin Bieber", Genres.Pop);
            Artist Dua = new Artist("Dua Lipa", Genres.Pop);
            Artist Drake = new Artist("Drake", Genres.Rap);
            Artist JLO = new Artist("Jennifer Lopez", Genres.Pop);
            Artist Tayler = new Artist("Taylor Swift", Genres.Pop);
            Artist Skrillex = new Artist("Skrillex", Genres.Dubstep);
            Artist Metallica = new Artist("Metallica", Genres.Metal);
            Artist Billie = new Artist("Billie Eilish", Genres.Pop);

            Justin.AddAlbum();
            Justin.AddAlbum();
            Drake.RemoveAlbum();

            List<Artist> artists = new List<Artist>();
            artists.Add(Justin);
            artists.Add(Dua);
            artists.Add(Drake);
            artists.Add(JLO);
            artists.Add(Tayler);
            artists.Add(Skrillex);
            artists.Add(Metallica);
            artists.Add(Billie);

            foreach (Artist A in artists)
            {
                Console.WriteLine(A);
            }

            Song sorry = new Song("Sorry", Justin, Genres.Pop, 2000);
            Song onekiss = new Song("One kiss", Dua, Genres.Pop, 3000);
            Song hotlineBling = new Song("Hotline Bling", Drake, Genres.Pop, 4000);
            Song onthefloor = new Song("On the floor", JLO, Genres.Pop, 5000);
            Song shakeitoff = new Song("Shake it off", Tayler, Genres.Pop, 6000);
            Song one = new Song("One", Metallica, Genres.Metal, 7000);
            Song bangerang = new Song("Bangerang", Skrillex, Genres.Dubstep, 8000);
            Song badguy = new Song("Bad Guy", Billie, Genres.Pop, 9000);

            List<Song> songs = new List<Song>();
            songs.Add(sorry);
            songs.Add(onekiss);
            songs.Add(hotlineBling);
            songs.Add(one);
            songs.Add(shakeitoff);
            songs.Add(onthefloor);
            songs.Add(bangerang);
            songs.Add(badguy);

            /*foreach (var item in songs)
            {
                item.Play();
            }*/

            PlayList DSPS = new PlayList("DSPS", songs);
            DSPS.Shuffle();
            Console.WriteLine(DSPS);

            DSPS.Play();

        }
    }
}
