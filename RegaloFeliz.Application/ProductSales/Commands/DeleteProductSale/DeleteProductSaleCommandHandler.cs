using MediatR;
using RegaloFeliz.Application.Responses;
using RegaloFeliz.Domain.Entities;

namespace RegaloFeliz.Application.ProductSales.Commands.DeleteProductSale
{
    public class DeleteProductSaleCommandHandler : IRequestHandler<DeleteProductSaleCommand, DeleteProductSaleDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public DeleteProductSaleCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<DeleteProductSaleDto> Handle(DeleteProductSaleCommand request, CancellationToken cancellationToken)
        {
            var productSale = new ProductSale()
            {
                Id = request.Id
            };
            _dbContext.ProductSales.Remove(productSale);
            await _dbContext.SaveChangesAsync();

            return new DeleteProductSaleDto(productSale.Id);
        }
    }
}
