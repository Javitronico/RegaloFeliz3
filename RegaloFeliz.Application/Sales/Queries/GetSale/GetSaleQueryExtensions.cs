using RegaloFeliz.Application.Responses;
using RegaloFeliz.Domain.Entities;

namespace RegaloFeliz.Application.Sales.Queries.GetSale
{
    public static class GetSaleQueryExtensions
    {
        public static GetSaleDto MapTo(this Sale sale)
        {
            return new GetSaleDto
            {
                Id= sale.Id,
                SaleDate = sale.SaleDate,
                ProductId= sale.ProductId,
                TotalAmount = sale.TotalAmount
            };
        }
    }
}
