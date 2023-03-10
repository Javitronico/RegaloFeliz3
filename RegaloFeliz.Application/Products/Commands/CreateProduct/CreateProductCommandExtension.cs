using RegaloFeliz.Domain.Entities;

namespace RegaloFeliz.Application.Products.Commands.CreateProduct
{
    public static class CreateProductCommandExtension
    {
        public static Product CreateProduct(this CreateProductCommand command)
        {
            Product product = new Product { Name = command.Name };

            return product;
        }
    }
}
