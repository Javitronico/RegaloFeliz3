namespace RegaloFeliz.Application.Requests.Sale
{
    public class UpdateSaleRequest
    {
        public long Id { get; set; }

        public DateTime SaleDate { get; set; }

        public float TotalAmount { get; set; }

    }
}
