using MediatR;
using RegaloFeliz.Application.Responses.Sale;

namespace RegaloFeliz.Application.Sales.Commands.UpdateSale
{
    public class UpdateSaleCommand : IRequest<UpdateSaleDto>
    {
        public UpdateSaleCommand(long id, DateTime saleDate, float totalAmount)
        {
            Id = id;
            SaleDate= saleDate;
            TotalAmount = totalAmount;
        }
        public long Id { get; internal set; }

        public DateTime SaleDate { get; internal set;}
        public float TotalAmount { get; internal set;}

    }
}
