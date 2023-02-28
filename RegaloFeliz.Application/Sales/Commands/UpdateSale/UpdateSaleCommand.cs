using MediatR;
using RegaloFeliz.Application.Responses;

namespace RegaloFeliz.Application.Sales.Commands.UpdateSale
{
    public class UpdateSaleCommand : IRequest<UpdateSaleDto>
    {
        public Guid Id { get; internal set; }
        public DateTime SaleDate { get; internal set; }
        public Guid ProductId { get; internal set; }
        public float TotalAmount { get; internal set; }

        public UpdateSaleCommand(Guid id, DateTime saleDate, Guid productId, float totalAmount)
        {
            Id = id;
            SaleDate = saleDate;
            ProductId= productId;
            TotalAmount = totalAmount;
        }
    }
}
