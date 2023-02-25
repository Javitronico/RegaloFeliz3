using MediatR;
using Microsoft.EntityFrameworkCore;
using RegaloFeliz.Application.Responses.Product;

namespace RegaloFeliz.Application.Products.Queries.GetProducts
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, IList<GetProductDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetProductsQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IList<GetProductDto>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _dbContext.Products.ToListAsync();
            var productList = new List<GetProductDto>();
            foreach (var productItem in products)
            {
                var product = productItem.MapTo();
                productList.Add(product);
            }

            return productList;
        }
    }
}
