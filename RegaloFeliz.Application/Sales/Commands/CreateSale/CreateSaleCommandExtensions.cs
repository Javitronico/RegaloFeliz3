using RegaloFeliz.Domain.Entities;

namespace RegaloFeliz.Application.Sales.Commands.CreateSale
{
    public static class CreateSaleCommandExtensions
    {
        public static Sale CreateSale(this CreateSaleCommand command)
        {
            Sale sale =
                new Sale { SaleDate = command.SaleDate, TotalAmount = command.TotalAmount };

            return sale;
        }
    }
}
