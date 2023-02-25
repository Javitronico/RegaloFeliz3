using MediatR;
using RegaloFeliz.Application.Responses.Product;

namespace RegaloFeliz.Application.Products.Queries.GetProducts;

public class GetProductsQuery : IRequest<IList<GetProductDto>>
{
}
