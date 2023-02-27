using Microsoft.EntityFrameworkCore;
using RegaloFeliz.Domain.Entities;

namespace RegaloFeliz.Application
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<ProductSale> ProductSales { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>()
                .HasMany(x => x.Sales);

            // Seed database with products and sales for demo porpuse
            new DbInitializer(builder).Seed();
        }
    }
}
