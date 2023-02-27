using RegaloFeliz.Application.Responses;
using RegaloFeliz.Domain.Entities;

namespace RegaloFeliz.Application.ProductSales.Queries.GetProductSales
{
    public static class GetProductSalesQueryExtensions
    {
        public static GetProductSaleDto MapTo(this ProductSale productSale)
        {
            return new GetProductSaleDto
            {
                Id = productSale.Id,
                ProductId = productSale.ProductId,
                SaleId = productSale.SaleId,
                Price = productSale.Price
            };
        }
    }
}
