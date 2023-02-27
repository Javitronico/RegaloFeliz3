using RegaloFeliz.Application.Responses;
using RegaloFeliz.Domain.Entities;

namespace RegaloFeliz.Application.Products.Queries.GetProducts
{
    public static class GetProductsQueryExtension
    {
        public static GetProductDto MapTo(this Product product)
        {
            return new GetProductDto
            {
                Id = product.Id,
                Name = product.Name
            };
        }
    }
}
