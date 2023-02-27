namespace RegaloFeliz.Application.Sales.Commands.DeleteSale
{
    public static class DeleteSaleCommandExtensions
    {
        public static Guid DeleteSale(this DeleteSaleCommand command)
        {
            return command.Id;
        }
    }
}
