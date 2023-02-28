using MediatR;
using RegaloFeliz.Application.Responses;

namespace RegaloFeliz.Application.Sales.Commands.CreateSale
{
    public class CreateSaleCommand : IRequest<CreateSaleDto>
    {
        public CreateSaleCommand(DateTime saleDate, Guid productId, float totalAmount)
        {
            ProductId= productId;
            SaleDate = saleDate;
            TotalAmount = totalAmount;
        }

        public DateTime SaleDate { get; set; } = DateTime.Now;
        public Guid ProductId { get; set; }
        public float TotalAmount { get; set; }
    }
}
