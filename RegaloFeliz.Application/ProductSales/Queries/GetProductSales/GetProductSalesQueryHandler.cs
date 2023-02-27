using MediatR;
using Microsoft.EntityFrameworkCore;
using RegaloFeliz.Application.ProductSales.Queries.GetProductSales;
using RegaloFeliz.Application.Responses;

namespace RegaloFeliz.Application.ProductSales.Queries
{
    public class GetProductSalesQueryHandler : IRequestHandler<GetProductSalesQuery, IList<GetProductSaleDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetProductSalesQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IList<GetProductSaleDto>> Handle(GetProductSalesQuery request, CancellationToken cancellationToken)
        {
            var productSales = await _dbContext.ProductSales.ToListAsync();
            var productSaleList = new List<GetProductSaleDto>();
            foreach (var productSaleItem in productSales)
            {
                var productSale = productSaleItem.MapTo();
                productSaleList.Add(productSale);
            }

            return productSaleList;
        }
    }
}
