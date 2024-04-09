using BulkyRef.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyRef.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }
        public DbSet<Category> Categories { get; set; }
    }
}
