using RegaloFeliz.Application.Responses;
using RegaloFeliz.Domain.Entities;

namespace RegaloFeliz.Application.ProductSales.Queries
{
    public static class GetProductSaleQueryExtension
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
