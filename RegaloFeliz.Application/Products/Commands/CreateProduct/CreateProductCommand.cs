using MediatR;
using RegaloFeliz.Application.Responses;

namespace RegaloFeliz.Application.Products.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<CreateProductDto>
    {
        public CreateProductCommand(string name)
        {
            Name = name;
        }

        public long Id { get; set; }

        public string Name { get; set; }
    }
}
