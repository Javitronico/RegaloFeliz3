using RegaloFeliz.Application.Responses.Sale;
using RegaloFeliz.Domain.Entities;

namespace RegaloFeliz.Application.Sales.Queries.GetSale
{
    public static class GetSaleQueryExtensions
    {
        public static GetSaleDto MapTo(this Sale sale)
        {
            return new GetSaleDto
            {
                SaleDate = sale.SaleDate,
                TotalAmount = sale.TotalAmount
            };
        }
    }
}
