namespace RegaloFeliz.Domain.Entities
{
    public class ProductSale
    {
        public long Id { get; set; }

        public Sale? Sale { get; set; }

        public Product? Product { get; set; }

        public float Price { get; set; }

    }
}
