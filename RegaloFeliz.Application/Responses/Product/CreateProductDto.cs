namespace RegaloFeliz.Application.Responses
{
    public class CreateProductDto
    {
        public CreateProductDto(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
