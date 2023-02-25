namespace RegaloFeliz.Application.Sales.Commands.DeleteSale
{
    public static class DeleteSaleCommandExtensions
    {
        public static long DeleteSale(this DeleteSaleCommand command)
        {
            return command.Id;
        }
    }
}
