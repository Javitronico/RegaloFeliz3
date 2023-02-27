using MediatR;
using Microsoft.EntityFrameworkCore;
using RegaloFeliz.Application.Responses;

namespace RegaloFeliz.Application.Sales.Queries.GetSale
{
    public class GetSaleQueryHandler : IRequestHandler<GetSaleQuery, GetSaleDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetSaleQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<GetSaleDto> Handle(GetSaleQuery request, CancellationToken cancellationToken)
        {
            var sale = await _dbContext.Sales.Where(x => x.Id == request.Id).FirstOrDefaultAsync();

            if (sale == null) return null;

            return sale.MapTo();
        }
    }
}
