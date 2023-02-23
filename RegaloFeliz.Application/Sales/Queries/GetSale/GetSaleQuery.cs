using MediatR;
using RegaloFeliz.Application.Responses.Product;
using RegaloFeliz.Application.Responses.Sale;

namespace RegaloFeliz.Application.Sales.Queries.GetSale
{
    public class GetSaleQuery : IRequest<GetSaleDto>
    {
        public GetSaleQuery(long? id)
        {
            Id = id;
        }

        public long? Id { get; set; }
    }
}
