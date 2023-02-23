using MediatR;
using Microsoft.EntityFrameworkCore;
using RegaloFeliz.Domain.DTOs.Responses.Product;
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
                Id = request.Id.Value
            };
            _dbContext.Products.Remove(product);
            await _dbContext.SaveChangesAsync();

            return new DeleteProductDto(product.Id);
        }
    }
}
