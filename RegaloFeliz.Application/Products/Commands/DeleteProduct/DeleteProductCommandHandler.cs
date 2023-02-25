using MediatR;
using RegaloFeliz.Application.Responses.Product;
using RegaloFeliz.Domain.Entities;

namespace RegaloFeliz.Application.Products.Commands.DeleteProduct
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, DeleteProductDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public DeleteProductCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<DeleteProductDto> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
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
