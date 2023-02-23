namespace RegaloFeliz.Application.Responses.Product
{
    public class UpdateProductDto
    {
        public UpdateProductDto(long id, string name)
        {
            Id = id;
            Name = name;
        }

        public long Id { get; set; }
        public string Name { get; set; }
    }
}
