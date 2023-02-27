using Microsoft.EntityFrameworkCore;
using RegaloFeliz.Domain.Entities;

namespace RegaloFeliz.Application
{
    public class DbInitializer
    {
        private readonly ModelBuilder _builder;

        public DbInitializer(ModelBuilder builder)
        {
            _builder = builder;
        }

        public void Seed()
        {
            _builder.Entity<Product>(p =>
            {
                p.HasData(new Product
                {
                    Id = new Guid("90d10994-3bdd-4ca2-a178-6a35fd653c59"),
                    Name = "God Of War"
                });
                p.HasData(new Product
                {
                    Id = new Guid("6ebc3dbe-2e7b-4132-8c33-e089d47694cd"),
                    Name = "FIFA 2023"
                });
            });

            _builder.Entity<Sale>(s =>
            {
                s.HasData(new Sale
                {
                    Id = new Guid("98474b8e-d713-401e-8aee-acb7353f97bb"),
                    ProductId = new Guid("90d10994-3bdd-4ca2-a178-6a35fd653c59"),
                    SaleDate = DateTime.Now.AddDays(-10),
                    TotalAmount = 100
                });
                s.HasData(new Sale
                {
                    Id = new Guid("bfe902af-3cf0-4a1c-8a83-66be60b028ba"),
                    ProductId = new Guid("90d10994-3bdd-4ca2-a178-6a35fd653c59"),
                    SaleDate = DateTime.Now.AddDays(-20),
                    TotalAmount = 200
                });
                s.HasData(new Sale
                {
                    Id = new Guid("150c81c6-2458-466e-907a-2df11325e2b8"),
                    ProductId = new Guid("6ebc3dbe-2e7b-4132-8c33-e089d47694cd"),
                    SaleDate = DateTime.Now.AddDays(-30),
                    TotalAmount = 300
                });
            });

            _builder.Entity<ProductSale>(ps =>
            {
                ps.HasData(new ProductSale
                {
                    Id = new Guid("E2D7C24A-73CA-4957-B4F9-345F635B03D3"),
                    ProductId = new Guid("90d10994-3bdd-4ca2-a178-6a35fd653c59"),
                    SaleId = new Guid("98474b8e-d713-401e-8aee-acb7353f97bb"),
                    Price = 100
                });
                ps.HasData(new ProductSale
                {
                    Id = new Guid("{F01ED6D5-BBA7-44F7-B28F-594AAF56B869}"),
                    ProductId = new Guid("6ebc3dbe-2e7b-4132-8c33-e089d47694cd"),
                    SaleId = new Guid("98474b8e-d713-401e-8aee-acb7353f97bb"),
                    Price = 100
                });
            });
        }
    }
}