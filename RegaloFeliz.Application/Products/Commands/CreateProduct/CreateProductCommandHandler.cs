using MediatR;
using RegaloFeliz.Application.Responses.Product;

namespace RegaloFeliz.Application.Products.Commands.CreateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductDto>
    {

        private readonly ApplicationDbContext _dbContext;

        public UpdateProductCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CreateProductDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = request.CreateProduct();
            await _dbContext.Products.AddAsync(product);
            await _dbContext.SaveChangesAsync();

            return new CreateProductDto(product.Id);
        }
    }
}
