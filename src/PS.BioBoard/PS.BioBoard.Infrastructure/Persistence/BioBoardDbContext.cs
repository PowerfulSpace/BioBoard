using Microsoft.EntityFrameworkCore;
using PS.BioBoard.Domain.Entites;

namespace PS.BioBoard.Infrastructure.Persistence
{
    public class BioBoardDbContext : DbContext
    {
        public BioBoardDbContext(DbContextOptions<BioBoardDbContext> options) : base(options)
        {
            
        }

        public DbSet<Person> Persons { get; set; } = null!;

    }
}
