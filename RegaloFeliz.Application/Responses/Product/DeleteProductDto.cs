namespace RegaloFeliz.Application.Responses
{
    public class DeleteProductDto
    {
        public Guid Id { get; set; }

        public DeleteProductDto(Guid id)
        {
            Id = id;
        }
    }
}
