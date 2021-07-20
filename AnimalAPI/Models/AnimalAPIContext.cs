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
    }
}