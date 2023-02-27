namespace RegaloFeliz.Application.Requests
{
    public class CreateSaleRequest
    {
        public DateTime SaleDate { get; set; }
        public float TotalAmount { get; set; }
        public Guid ProductId { get; set; }
    }
}
