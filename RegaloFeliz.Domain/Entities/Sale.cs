using System.ComponentModel.DataAnnotations;

namespace RegaloFeliz.Domain.Entities
{
    public class Sale
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime SaleDate { get; set; }
        public float TotalAmount { get; set; }

        // One-to-many relation with products
        public Guid ProductId { get; set; }
        public Product? Product { get; set; }

    }
}
