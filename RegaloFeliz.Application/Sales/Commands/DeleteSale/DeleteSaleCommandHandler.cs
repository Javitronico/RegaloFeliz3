using MediatR;
using RegaloFeliz.Application.Responses;
using RegaloFeliz.Domain.Entities;

namespace RegaloFeliz.Application.Sales.Commands.DeleteSale
{
    public class DeleteSaleCommandHandler : IRequestHandler<DeleteSaleCommand, DeleteSaleDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public DeleteSaleCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<DeleteSaleDto> Handle(DeleteSaleCommand request, CancellationToken cancellationToken)
        {
            var sale = new Sale(){Id = request.Id};

            _dbContext.Sales.Remove(sale);
            await _dbContext.SaveChangesAsync();

            return new DeleteSaleDto(sale.Id);
        }
    }
}
