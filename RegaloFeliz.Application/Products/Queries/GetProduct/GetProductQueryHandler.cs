using MediatR;
using Microsoft.EntityFrameworkCore;
using RegaloFeliz.Application.Responses;

namespace RegaloFeliz.Application.Products.Queries.GetProduct
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, GetProductDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetProductQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<GetProductDto> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var product = await _dbContext.Products.Where(x => x.Id == request.Id).FirstOrDefaultAsync();

            if (product == null) { return default; }

            return product.MapTo();

        }
    }
}
