using MediatR;
using RegaloFeliz.Application.Responses;

namespace RegaloFeliz.Application.Products.Commands.UpdateProduct

{
    public class UpdateProductCommand : IRequest<UpdateProductDto>
    {
        public UpdateProductCommand(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
        public Guid Id { get; internal set; }

        public string Name { get; set; }
    }
}