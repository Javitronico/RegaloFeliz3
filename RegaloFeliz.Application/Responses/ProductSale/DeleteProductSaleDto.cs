namespace RegaloFeliz.Application.Responses
{
    public class DeleteProductSaleDto
    {
        public long Id { get; set; }

        public DeleteProductSaleDto(long id)
        {
            Id = id;
        }
    }
}
