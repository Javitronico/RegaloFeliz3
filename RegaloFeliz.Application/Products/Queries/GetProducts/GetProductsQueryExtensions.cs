using RegaloFeliz.Application.Responses.Product;
using RegaloFeliz.Domain.Entities;

namespace RegaloFeliz.Application.Products.Queries.GetProducts
{
    public static class GetProductsQueryExtensions
    {
        public static GetProductDto MapTo(this Product dto)
        {
            return new GetProductDto
            {
                Id = dto.Id,
                Name = dto.Name
            };
        }

    }
}
