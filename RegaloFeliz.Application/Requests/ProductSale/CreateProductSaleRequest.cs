namespace RegaloFeliz.Application.Requests
{
    public class CreateProductSaleRequest
    {
        public Guid ProductId { get; set; }
        public Guid SaleId { get; set; }
        public float Price { get; set; }

    }
}
