using RegaloFeliz.Application.Commands.CreateProductSale;
using RegaloFeliz.Domain.Entities;

namespace RegaloFeliz.Application.ProductSales.Commands.CreateProductSale
{
    public static class CreateProductSaleCommandExtension
    {
        public static ProductSale CreateProductSale(this CreateProductSaleCommand command)
        {
            var productSale = new ProductSale
            {
                ProductId = command.ProductId,
                SaleId = command.SaleId,
                Price = command.Price
            };

            return productSale;
        }
    }
}
