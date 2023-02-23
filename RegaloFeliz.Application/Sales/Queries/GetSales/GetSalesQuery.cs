using MediatR;
using RegaloFeliz.Application.Responses.Sale;

namespace RegaloFeliz.Application.Sales.Queries.GetSales
{
    public class GetSalesQuery : IRequest<IList<GetSaleDto>>
    {
    }
}
