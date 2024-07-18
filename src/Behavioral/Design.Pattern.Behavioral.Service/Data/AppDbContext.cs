using Design.Pattern.Behavioral.Service.Entities;
using Microsoft.EntityFrameworkCore;

namespace Design.Pattern.Behavioral.Service.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseInMemoryDatabase("AppDb");
            }
        }
    }
}
