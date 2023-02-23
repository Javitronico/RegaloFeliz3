namespace RegaloFeliz.Application.Responses.Sale
{
    public class DeleteSaleDto
    {
        public DeleteSaleDto(long id)
        {
            Id = id;
        }

        public long Id { get; set; }
    }
}
