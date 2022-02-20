using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Intro
{
    public class MC_Db : DbContext
    {
        public MC_Db()
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"data source=(LocalDb)\MSSQLLocalDB;initial catalog=MusicalCollection_NEW;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Initialize
            modelBuilder.Entity<Country>().HasData
            (
                new Country() { Name = "USA" },
                new Country() { Name = "Ukraine" },
                new Country() { Name = "France" },
                new Country() { Name = "Mexico" }
            );
            modelBuilder.Entity<Genre>().HasData
            (
                new Genre() { Name = "Rock" },
                new Genre() { Name = "Pop" },
                new Genre() { Name = "Instrumental" },
                new Genre() { Name = "Folk" }
            );
            modelBuilder.Entity<Category>().HasData
            (
                new Category() { Name = "Sad Songs" },
                new Category() { Name = "Dance Mucic" },
                new Category() { Name = "1990's" },
                new Category() { Name = "Top 2021" }
            );
        }
        // Collections (tables in db)
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Country> Counties { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
