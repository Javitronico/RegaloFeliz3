using System.ComponentModel.DataAnnotations;

namespace RegaloFeliz.Domain.Entities
{
    public class ProductSale
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        //public Product Product { get; set; }
        public Guid SaleId { get; set; }
        //public Sale Sale { get; set; }
        public float Price { get; set; }

    }
}
