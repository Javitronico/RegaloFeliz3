namespace RegaloFeliz.Application.Responses
{
    public class CreateProductSaleDto
    {
        public Guid Id { get; set; }

        public CreateProductSaleDto(Guid id)
        {
            Id = id;
        }
    }
}
