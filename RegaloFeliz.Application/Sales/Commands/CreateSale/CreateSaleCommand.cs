using MediatR;
using RegaloFeliz.Application.Responses.Sale;

namespace RegaloFeliz.Application.Sales.Commands.CreateSale
{
    public class CreateSaleCommand : IRequest<CreateSaleDto>
    {
        public CreateSaleCommand(DateTime saleDate, float totalAmount)
        {
            SaleDate = saleDate;
            TotalAmount = totalAmount;
        }

        public DateTime SaleDate { get; set; } = DateTime.Now;
        public float TotalAmount { get; set; }
    }
}
