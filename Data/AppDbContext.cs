using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options) 
        {            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>()
                .HasKey(am => new
                {
                    am.ActorId,
                    am.MovieId
                });

            modelBuilder.Entity<Actor_Movie>()
                .HasOne(m => m.Movie)
                .WithMany(am => am.Actors_Movies)
                .HasForeignKey(m => m.MovieId);

            modelBuilder.Entity<Actor_Movie>()
                .HasOne(m => m.Actor)
                .WithMany(am => am.Actors_Movies)
                .HasForeignKey(m => m.ActorId);

            base.OnModelCreating(modelBuilder);
        }

        DbSet<Actor> Actors { get; set; }
        DbSet<Movie> Movies { get; set; }
        DbSet<Actor_Movie> Actors_Movies { get; set; }
        DbSet<Cinema> Cinemas { get; set; }
        DbSet<Producer> Producers { get; set; }
    }
}
