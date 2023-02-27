namespace RegaloFeliz.Application.Responses
{
    public class UpdateProductSaleDto
    {
        public UpdateProductSaleDto(Guid id, Guid productId, Guid saleId, float price)
        {
            Id = id;
            ProductId = productId;
            SaleId = saleId;
            Price = price;
        }

        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid SaleId { get; set; }
        public float Price { get; set; }
    }
}
