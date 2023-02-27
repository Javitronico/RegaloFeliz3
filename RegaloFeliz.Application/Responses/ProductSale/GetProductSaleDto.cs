namespace RegaloFeliz.Application.Responses
{
    public class GetProductSaleDto
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid SaleId { get; set; }
        public float Price { get; set; }
    }
}
