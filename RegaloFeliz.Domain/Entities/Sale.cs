namespace RegaloFeliz.Domain.Entities
{
    public class Sale
    {
        public long Id { get; set; }    

        public DateTime SaleDate { get; set; }

        public float TotalAmount { get; set; }
    }
}
