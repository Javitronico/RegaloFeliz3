using RegaloFeliz.Application.Responses.Product;
using RegaloFeliz.Domain.Entities;

namespace RegaloFeliz.Application.Products.Queries.GetProduct
{
    public static class GetProductQueryExtensions
    {
        public static GetProductDto MapTo(this Product product)
        {
            return new GetProductDto
            {
                Name = product.Name
            };
        }
    }
}
