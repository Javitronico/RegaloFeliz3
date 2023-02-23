using RegaloFeliz.Domain.Entities;

namespace RegaloFeliz.Application.DTOs.Requests.ProductSale
{
    public class CreateProductSaleRequest
    {
        public Sale? Sale { get; set; }

        public Product? Product { get; set; }

        public float Price { get; set; }

    }
}
