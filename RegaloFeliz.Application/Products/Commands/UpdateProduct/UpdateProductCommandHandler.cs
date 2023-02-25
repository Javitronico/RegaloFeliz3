using MediatR;
using Microsoft.EntityFrameworkCore;
using RegaloFeliz.Application.Responses.Product;

namespace RegaloFeliz.Application.Products.Commands.UpdateProduct;

public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, UpdateProductDto>
{

    private readonly ApplicationDbContext _dbContext;

    public UpdateProductCommandHandler(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<UpdateProductDto> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var product = await _dbContext.Products.Where(x => x.Id == request.Id).FirstOrDefaultAsync();

        if (product == null) return default;

        product.Name = request.Name;

        _dbContext.Products.Update(product);
        await _dbContext.SaveChangesAsync();

        return new UpdateProductDto(product.Id, product.Name);
    }
}
