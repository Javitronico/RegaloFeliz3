using MediatR;
using Microsoft.EntityFrameworkCore;
using RegaloFeliz.Application.Responses;

namespace RegaloFeliz.Application.Sales.Commands.UpdateSale
{
    public class UpdateSaleCommandHandler : IRequestHandler<UpdateSaleCommand, UpdateSaleDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public UpdateSaleCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<UpdateSaleDto> Handle(UpdateSaleCommand request, CancellationToken cancellationToken)
        {
            var searchedSale = await _dbContext.Sales.Where(x => x.Id == request.Id).FirstOrDefaultAsync();

            if (searchedSale == null) return null;

            searchedSale.SaleDate = request.SaleDate;
            searchedSale.ProductId = request.ProductId;
            searchedSale.TotalAmount = request.TotalAmount;

            _dbContext.Sales.Update(searchedSale);
            await _dbContext.SaveChangesAsync();

            return new UpdateSaleDto(searchedSale.Id, searchedSale.SaleDate, searchedSale.ProductId, searchedSale.TotalAmount);
        }
    }
}
