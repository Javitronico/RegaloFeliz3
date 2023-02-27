namespace RegaloFeliz.Application.Products.Commands.DeleteProduct
{
    public static class DeleteProductCommandExtension
    {
        public static Guid DeleteProduct(this DeleteProductCommand command)
        {
            return command.Id;
        }
    }
}
