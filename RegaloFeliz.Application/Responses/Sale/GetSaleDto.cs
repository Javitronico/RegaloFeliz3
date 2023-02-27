namespace RegaloFeliz.Application.Responses
{
    public class GetSaleDto
    {
        public Guid Id { get; set; }
        public DateTime SaleDate { get; set; }
        public float TotalAmount { get; set; }
    }
}
