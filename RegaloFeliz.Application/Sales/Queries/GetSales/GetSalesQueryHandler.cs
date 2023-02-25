using MediatR;
using Microsoft.EntityFrameworkCore;
using RegaloFeliz.Application.Responses.Sale;

namespace RegaloFeliz.Application.Sales.Queries.GetSales
{
    public class GetSalesQueryHandler : IRequestHandler<GetSalesQuery, IList<GetSaleDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetSalesQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IList<GetSaleDto>> Handle(GetSalesQuery request, CancellationToken cancellationToken)
        {
            var sales = await _dbContext.Sales.ToListAsync();
            var saleList = new List<GetSaleDto>();
            foreach (var saleItem in sales)
            {
                var sale = saleItem.MapTo();
                saleList.Add(sale);
            }

            return saleList;
        }
    }
}
