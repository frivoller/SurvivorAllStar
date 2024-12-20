using Microsoft.EntityFrameworkCore;
using SurvivorProject.Model.Entity;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace SurvivorProject.Model.Context
{
    public class SurvivorDbContext : DbContext
    {
        public SurvivorDbContext(DbContextOptions<SurvivorDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Competitors> Competitors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Category - Competitor ilişkisi (One-to-Many)
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Competitors)
                .WithOne(c => c.Category)
                .HasForeignKey(c => c.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}