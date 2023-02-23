using MediatR;
using RegaloFeliz.Application.Responses.Product;

namespace RegaloFeliz.Application.Products.Queries.GetProduct
{
    public class GetProductQuery : IRequest<GetProductDto>
    {
        public GetProductQuery(long? id)
        {
            Id = id;
        }

        public long? Id { get; set; }
    }
}
