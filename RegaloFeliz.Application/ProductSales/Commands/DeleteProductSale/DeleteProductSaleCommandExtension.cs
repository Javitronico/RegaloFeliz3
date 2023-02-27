namespace RegaloFeliz.Application.ProductSales.Commands.DeleteProductSale
{
    public static class DeleteProductSaleCommandExtension
    {
        public static Guid DeleteProductSale(this DeleteProductSaleCommand command)
        {
            return command.Id;
        }
    }
}
