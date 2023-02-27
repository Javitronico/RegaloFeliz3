using System.ComponentModel.DataAnnotations;

namespace RegaloFeliz.Domain.Entities
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }

        // One-to-many relationship with sale
        public List<Sale>? Sales { get; set; }
    }
}