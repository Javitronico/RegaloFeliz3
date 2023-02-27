using MediatR;
using RegaloFeliz.Application.Responses;

namespace RegaloFeliz.Application.Sales.Commands.CreateSale
{
    public class CreateSaleCommandHandler : IRequestHandler<CreateSaleCommand, CreateSaleDto>
    {

        private readonly ApplicationDbContext _dbContext;

        public CreateSaleCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CreateSaleDto> Handle(CreateSaleCommand request, CancellationToken cancellationToken)
        {
            var sale = request.CreateSale();
            await _dbContext.Sales.AddAsync(sale);
            await _dbContext.SaveChangesAsync();

            return new CreateSaleDto(sale.Id);
        }
    }
}
