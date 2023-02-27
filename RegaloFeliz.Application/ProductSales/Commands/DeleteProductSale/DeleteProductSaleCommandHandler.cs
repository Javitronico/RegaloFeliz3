using RegaloFeliz.Application.Responses;
using RegaloFeliz.Domain.Entities;

namespace RegaloFeliz.Application.ProductSales.Commands.DeleteProductSale
{
    public class DeleteProductSaleCommandHandler
    {
        private readonly ApplicationDbContext _dbContext;

        public DeleteProductSaleCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<DeleteProductDto> Handle(DeleteProductSaleCommand request, CancellationToken cancellationToken)
        {
            var product = new Product()
            {
                Id = request.Id
            };
            _dbContext.Products.Remove(product);
            await _dbContext.SaveChangesAsync();

            return new DeleteProductDto(product.Id);
        }
    }
}
