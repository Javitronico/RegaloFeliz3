using RegaloFeliz.Domain.Entities;

namespace RegaloFeliz.Application.Sales.Commands.CreateSale
{
    public static class CreateSaleCommandExtension
    {
        public static Sale CreateSale(this CreateSaleCommand command)
        {
            Sale sale =
                new Sale { SaleDate = command.SaleDate, ProductId = command.ProductId, TotalAmount = command.TotalAmount };

            return sale;
        }
    }
}
