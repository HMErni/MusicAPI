using Microsoft.EntityFrameworkCore;
using MusicAPI.Models;

namespace MusicAPI.Data
{
    public class MusicContext : DbContext{

        public MusicContext(DbContextOptions<MusicContext> options) : base(options)
        {
            
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Music> Musics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Genre>().HasData(new Genre{
                GenreName = "Rock",
                Id = 1
            });
            modelBuilder.Entity<Genre>().HasData(new Genre{
                GenreName = "Pop",
                Id = 2
            });
            modelBuilder.Entity<Genre>().HasData(new Genre{
                GenreName = "Jazz",
                Id = 3
            });
        }
    }
}