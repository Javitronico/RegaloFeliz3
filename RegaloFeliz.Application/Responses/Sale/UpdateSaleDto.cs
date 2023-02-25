namespace RegaloFeliz.Application.Responses.Sale
{
    public class UpdateSaleDto
    {
        public UpdateSaleDto(long id, DateTime saleDate, float totalAmount)
        {
            Id = id;
            SaleDate = saleDate;
            TotalAmount = totalAmount;
        }

        public long Id { get; set; }
        public DateTime SaleDate { get; set; } = DateTime.Now;
        public float TotalAmount { get; set; }
    }
}
