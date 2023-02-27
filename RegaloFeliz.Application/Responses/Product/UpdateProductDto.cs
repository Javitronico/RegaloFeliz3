namespace RegaloFeliz.Application.Responses
{
    public class UpdateProductDto
    {
        public UpdateProductDto(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
