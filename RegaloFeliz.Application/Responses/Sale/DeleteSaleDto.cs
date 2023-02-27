namespace RegaloFeliz.Application.Responses
{
    public class DeleteSaleDto
    {
        public Guid Id { get; set; }
        public DeleteSaleDto(Guid id)
        {
            Id = id;
        }
    }
}
