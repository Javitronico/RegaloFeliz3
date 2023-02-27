using MediatR;
using Microsoft.EntityFrameworkCore;
using RegaloFeliz.Application.Products.Commands.UpdateProduct;
using RegaloFeliz.Application.Responses;

namespace RegaloFeliz.Application.ProductSales.Commands.UpdateProductSale
{
    public class UpdateProductSaleCommandHandler : IRequestHandler<UpdateProductSaleCommand, UpdateProductSaleDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public UpdateProductSaleCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<UpdateProductSaleDto> Handle(UpdateProductSaleCommand request, CancellationToken cancellationToken)
        {
            var productSale = await _dbContext.ProductSales.Where(x => x.Id == request.Id).FirstOrDefaultAsync();

            if (productSale == null) return default;

            productSale.ProductId= request.Id;
            productSale.SaleId= request.Id;

            _dbContext.ProductSales.Update(productSale);
            await _dbContext.SaveChangesAsync();

            return new UpdateProductSaleDto(productSale.Id, productSale.ProductId, productSale.SaleId, productSale.Price);
        }

    }
}
