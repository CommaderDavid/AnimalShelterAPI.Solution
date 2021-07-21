using Microsoft.EntityFrameworkCore;

namespace AnimalAPI.Models
{
    public class AnimalAPIContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }

        public AnimalAPIContext(DbContextOptions<AnimalAPIContext> options)
          : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Animal>()
              .HasData(
                new Animal { AnimalId = 1, Name = "Malinda", Type = "Dog", Gender = "Female", Behavior = "Wonderful and sublime. Fantastic around kids.", DateAdded = "April 2, 2009" },
                new Animal { AnimalId = 2, Name = "Boof", Type = "Dog", Gender = "Male", Behavior = "Loud and Obnoctus. But a gentel giant.", DateAdded = "June 8, 2012" },
                new Animal { AnimalId = 3, Name = "Charlie", Type = "Cat", Gender = "Male", Behavior = "Little shit. Low energy and calm during night.", DateAdded = "Febuary 28, 2015" },
                new Animal { AnimalId = 4, Name = "Spot", Type = "Cat", Gender = "Female", Behavior = "Wonderful and sublime. Does not enjoy the audiunce of childeren.", DateAdded = "April 1, 2018" }
            );
        }
    }
}