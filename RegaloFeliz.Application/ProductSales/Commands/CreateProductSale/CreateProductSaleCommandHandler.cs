using MediatR;
using RegaloFeliz.Application.Commands.CreateProductSale;
using RegaloFeliz.Application.Responses;

namespace RegaloFeliz.Application.ProductSales.Commands.CreateProductSale
{
    public class CreateProductSaleCommandHandler : IRequestHandler<CreateProductSaleCommand, CreateProductSaleDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public CreateProductSaleCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CreateProductSaleDto> Handle(CreateProductSaleCommand request, CancellationToken cancellationToken)
        {
            var productSale = request.CreateProductSale();
            await _dbContext.ProductSales.AddAsync(productSale);
            await _dbContext.SaveChangesAsync();

            return new CreateProductSaleDto(productSale.Id);
        }
    }
}
