namespace RegaloFeliz.Application.Responses.Sale
{
    public class CreateSaleDto
    {
        public CreateSaleDto(long id)
        {
            Id = id;
        }
        public long Id { get; set; }
    }
}
