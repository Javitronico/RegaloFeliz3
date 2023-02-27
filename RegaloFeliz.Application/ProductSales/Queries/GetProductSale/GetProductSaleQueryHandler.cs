using MediatR;
using Microsoft.EntityFrameworkCore;
using RegaloFeliz.Application.ProductSales.Queries.GetProductSale;
using RegaloFeliz.Application.Responses;

namespace RegaloFeliz.Application.ProductSales.Queries
{
    public class GetProductSaleQueryHandler : IRequestHandler<GetProductSaleQuery, GetProductSaleDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetProductSaleQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<GetProductSaleDto> Handle(GetProductSaleQuery request, CancellationToken cancellationToken)
        {
            var productSale = await _dbContext.ProductSales.Where(x => x.Id == request.Id).FirstOrDefaultAsync();

            if (productSale == null) { return default; }

            return productSale.MapTo();

        }

    }
}
