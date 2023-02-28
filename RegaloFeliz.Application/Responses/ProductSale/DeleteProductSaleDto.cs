namespace RegaloFeliz.Application.Responses
{
    public class DeleteProductSaleDto
    {
        public Guid Id { get; set; }

        public DeleteProductSaleDto(Guid id)
        {
            Id = id;
        }
    }
}
