using MediatR;
using RegaloFeliz.Application.Responses;

namespace RegaloFeliz.Application.Products.Queries.GetProducts
{
    public class GetProductsQuery : IRequest<IList<GetProductDto>>
    {
    }
}