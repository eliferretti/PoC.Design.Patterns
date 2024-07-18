using Design.Pattern.Structural.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace Design.Pattern.Structural.Repository.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("AppDb");
        }
    }
}
