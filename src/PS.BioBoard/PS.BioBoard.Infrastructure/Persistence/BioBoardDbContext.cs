﻿using Microsoft.EntityFrameworkCore;
using PS.BioBoard.Domain.Entities;

namespace PS.BioBoard.Infrastructure.Persistence
{
    public class BioBoardDbContext : DbContext
    {
        public BioBoardDbContext(DbContextOptions<BioBoardDbContext> options) : base(options)
        {
            
        }

        public DbSet<Person> Persons { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfigurationsFromAssembly(typeof(BioBoardDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

    }
}
