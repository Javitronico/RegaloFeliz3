using MediatR;
using RegaloFeliz.Application.Responses;

namespace RegaloFeliz.Application.Commands.CreateProductSale
{
    public class CreateProductSaleCommand : IRequest<CreateProductSaleDto>
    {
        public Guid ProductId { get; set; }
        public Guid SaleId { get; set; }
        public float Price { get; set; }
        public CreateProductSaleCommand(Guid productId, Guid saleId, float price)
        {
            ProductId = productId;
            SaleId = saleId;
            Price = price;
        }
    }
}
