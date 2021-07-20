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
                new Animal { AnimalId = 1, Name = "Malinda", Type = "Dog", Gender = "Female", Behavior = "Wonderful and sublime. Fantastic around kids.", DateAdded = "April 2, 2009" }
            );
        }
    }
}