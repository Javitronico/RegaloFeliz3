namespace RegaloFeliz.Application.Responses
{
    public class CreateSaleDto
    {
        public Guid Id { get; set; }
        public CreateSaleDto(Guid id)
        {
            Id = id;
        }
    }
}
