using MediatR;
using RegaloFeliz.Application.Responses;

namespace RegaloFeliz.Application.ProductSales.Queries.GetProductSale
{
    public class GetProductSaleQuery : IRequest<GetProductSaleDto>
    {
        public Guid Id { get; set; }
        public GetProductSaleQuery(Guid id)
        {
            Id = id;
        }
    }
}
