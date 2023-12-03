using RZBio1._1.Models;
using Microsoft.EntityFrameworkCore;
namespace RZBio1._1.Data
{
    public class CinemaContext: DbContext
    {
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options) { }


       
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Lounge> Lounges { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Show> Shows { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>().ToTable("Booking");
            modelBuilder.Entity<Lounge>().ToTable("Lounge");
            modelBuilder.Entity<Movie>().ToTable("Movie");
            modelBuilder.Entity<Show>().ToTable("Show");
        }
    }
}