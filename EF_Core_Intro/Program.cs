using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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

            //Task 2:

            var first = db.Songs.Include(a => a.Album).Where(a => a.Listens > db.Songs.Include(a => a.Album).Average(a => a.Listens));
            var second = db.Albums.Include(a => a.Artist).Select(a => a.Listens).Take(3);
            var third = db.Songs.Select(s => s.Name).Where(s => s.Contains("All Be Alright"));

        }
    }
}
