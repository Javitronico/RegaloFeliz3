using RegaloFeliz.Domain.Entities;

namespace RegaloFeliz.Application.ProductSales.Commands.UpdateProductSale
{
    public static class UpdateProductSaleCommandExtension
    {
        public static ProductSale UpdateProductSale(this UpdateProductSaleCommand command)
        {
            var productSale = new ProductSale
            {
                Id = command.Id,
                ProductId = command.ProductId,
                SaleId = command.SaleId,
                Price = command.Price
            };

            return productSale;
        }
    }
}
