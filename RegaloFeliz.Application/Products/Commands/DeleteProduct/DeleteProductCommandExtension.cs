namespace RegaloFeliz.Application.Products.Commands.DeleteProduct
{
    public static class DeleteProductCommandExtension
    {
        public static long DeleteProduct(this DeleteProductCommand command)
        {
            return command.Id;
        }
    }
}
