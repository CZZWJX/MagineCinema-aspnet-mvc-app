using MagineCinema.Models;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;

namespace MagineCinema.Data
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.actorId,
                am.movieId
            });

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.movie).WithMany(am => am.actors_Movies).HasForeignKey(m => m.movieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.actor).WithMany(am => am.actors_Movies).HasForeignKey(m => m.actorId);

            modelBuilder.Entity<Director_Movie>().HasKey(dm => new
            {
                dm.directorId,
                dm.movieId
            });

            modelBuilder.Entity<Director_Movie>().HasOne(m => m.director).WithMany(am => am.directors_Movies).HasForeignKey(m => m.directorId);
            modelBuilder.Entity<Director_Movie>().HasOne(m => m.movie).WithMany(am => am.directors_Movies).HasForeignKey(m => m.movieId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actor { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Director> Director { get; set; }
        public DbSet<Actor_Movie> Actor_Movie { get; set; }
        public DbSet<Director_Movie> Director_Movie { get; set; }
    }
}
