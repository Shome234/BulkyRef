using BulkyRef.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyRef.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1,Name="Action",DisplayOrder=90},
                new Category() { Id = 9, Name = "History", DisplayOrder = 89 },
                new Category() { Id = 8, Name = "Live", DisplayOrder = 19 }
            );
        }
    }
}
