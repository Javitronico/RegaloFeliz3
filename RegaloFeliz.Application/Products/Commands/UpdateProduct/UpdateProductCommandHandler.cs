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
        var searchedProduct = await _dbContext.Products.Where(x => x.Id == request.Id).FirstOrDefaultAsync();

        if (searchedProduct == null) return null;

        searchedProduct.Name= request.Name;

        //var product = request.UpdateProduct();
        _dbContext.Products.Update(searchedProduct);
        await _dbContext.SaveChangesAsync();

        return new UpdateProductDto(searchedProduct.Id, searchedProduct.Name);
    }
}
