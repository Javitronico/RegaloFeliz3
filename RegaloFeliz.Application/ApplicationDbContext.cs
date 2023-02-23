using Microsoft.EntityFrameworkCore;
using RegaloFeliz.Domain.Entities;

namespace RegaloFeliz.Application
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Sale> Sales { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductSale> ProductSales { get; set; }
    }
}
