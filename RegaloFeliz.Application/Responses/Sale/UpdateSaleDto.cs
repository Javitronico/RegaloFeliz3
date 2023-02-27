namespace RegaloFeliz.Application.Responses
{
    public class UpdateSaleDto
    {
        public UpdateSaleDto(Guid id, DateTime saleDate, float totalAmount)
        {
            Id = id;
            SaleDate = saleDate;
            TotalAmount = totalAmount;
        }

        public Guid Id { get; set; }
        public DateTime SaleDate { get; set; } = DateTime.Now;
        public float TotalAmount { get; set; }
    }
}
