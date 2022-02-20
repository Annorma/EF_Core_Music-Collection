using System;
using System.Linq;

namespace EF_Core_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            MC_Db db = new MC_Db();
            
            foreach (var item in db.Artists)
            {
                Console.WriteLine($"Artist #{item.Id} {item.Name} {item.Surname} - {item.Country}");
            }

            foreach (var item in db.Playlists)
            {
                Console.WriteLine($"Playlist #{item.Id} {item.Name} {item.Songs} - {item.Category}");
            }

            foreach (var item in db.Albums)
            {
                Console.WriteLine($"Album #{item.Id} {item.Name} {item.Genre} {item.Artist} {item.Year}");
            }

            foreach (var item in db.Songs)
            {
                Console.WriteLine($"Song #{item.Id} {item.Name} {item.Duration}");
            }
            
            foreach (var item in db.Counties)
            {
                Console.WriteLine($"Country #{item.Name}");
            }

            foreach (var item in db.Genres)
            {
                Console.WriteLine($"Genre #{item.Name}");
            }

            foreach (var item in db.Categories)
            {
                Console.WriteLine($"Category #{item.Name}");
            }
        }
    }
}
