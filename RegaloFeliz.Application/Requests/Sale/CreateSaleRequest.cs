namespace RegaloFeliz.Application.Requests.Sale
{
    public class CreateSaleRequest
    {
        public DateTime SaleDate { get; set; }
        public float TotalAmount { get; set; }
    }
}
