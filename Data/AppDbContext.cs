using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Ecommerce.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieActor>().HasKey(am => new
            {
                am.MovieId,
                am.ActorId
            });  

            modelBuilder.Entity<MovieActor>().HasOne(m => m.Movies).WithMany(am => am.MovieActors).HasForeignKey(am => am.MovieId);
            modelBuilder.Entity<MovieActor>().HasOne(m => m.Actors).WithMany(am => am.MovieActors).HasForeignKey(am => am.MovieId);

            base.OnModelCreating(modelBuilder);

            //We can also create seeder here.
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieActor> MovieActors { get; set; }
        public DbSet<MovieCategory> MovieCategories { get; set; }
    }
}