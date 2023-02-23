namespace RegaloFeliz.Application.Responses.Product
{
    public class CreateProductDto
    {
        public CreateProductDto(long id)
        {
            Id = id;
        }

        public long Id { get; set; }
    }
}
