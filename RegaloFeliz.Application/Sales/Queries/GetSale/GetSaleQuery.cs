using MediatR;
using RegaloFeliz.Application.Responses;

namespace RegaloFeliz.Application.Sales.Queries.GetSale
{
    public class GetSaleQuery : IRequest<GetSaleDto>
    {
        public GetSaleQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
