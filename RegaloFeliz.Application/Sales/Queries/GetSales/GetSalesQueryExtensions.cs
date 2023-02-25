using RegaloFeliz.Application.Responses.Sale;
using RegaloFeliz.Domain.Entities;

namespace RegaloFeliz.Application.Sales.Queries.GetSales
{
    public static class GetSalesQueryExtensions
    {
        public static GetSaleDto MapTo(this Sale sale)
        {
            return new GetSaleDto
            {
                Id= sale.Id,
                SaleDate = sale.SaleDate,
                TotalAmount = sale.TotalAmount
            };
        }
    }
}
