namespace RegaloFeliz.Application.Responses.Sale
{
    public class GetSaleDto
    {
        public long Id { get; set; }
        public DateTime SaleDate { get; set; }
        public float TotalAmount { get; set; }
    }
}
