using MediatR;
using RegaloFeliz.Application.Responses;

namespace RegaloFeliz.Application.ProductSales.Queries.GetProductSales
{
    public class GetProductSalesQuery : IRequest<IList<GetProductSaleDto>>
    {
    }
}