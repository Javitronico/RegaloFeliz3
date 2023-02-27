using MediatR;
using RegaloFeliz.Application.Responses;

namespace RegaloFeliz.Application.ProductSales.Commands.UpdateProductSale
{
    public class UpdateProductSaleCommand : IRequest<UpdateProductSaleDto>
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid SaleId { get; set; }
        public float Price { get; set; }
        public UpdateProductSaleCommand(Guid id, Guid productId, Guid saleId, float price)
        {
            Id = id;
            ProductId = productId;
            SaleId = saleId;
            Price = price;
        }
    }
}
