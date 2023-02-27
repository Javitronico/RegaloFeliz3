using MediatR;
using RegaloFeliz.Application.Responses;

namespace RegaloFeliz.Application.Products.Queries.GetProduct
{
    public class GetProductQuery : IRequest<GetProductDto>
    {
        public Guid Id { get; set; }
        public GetProductQuery(Guid id)
        {
            Id = id;
        }
    }
}
