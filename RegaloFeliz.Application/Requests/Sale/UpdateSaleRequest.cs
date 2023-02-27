namespace RegaloFeliz.Application.Requests
{
    public class UpdateSaleRequest
    {
        public Guid Id { get; set; }

        public DateTime SaleDate { get; set; }

        public float TotalAmount { get; set; }

    }
}
