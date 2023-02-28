namespace RegaloFeliz.Application.Responses
{
    public class UpdateSaleDto
    {
        public UpdateSaleDto(Guid id, DateTime saleDate, Guid productId, float totalAmount)
        {
            Id = id;
            SaleDate = saleDate;
            ProductId = productId;
            TotalAmount = totalAmount;
        }

        public Guid Id { get; set; }
        public DateTime SaleDate { get; set; } = DateTime.Now;
        public Guid ProductId { get; set; }
        public float TotalAmount { get; set; }
    }
}
