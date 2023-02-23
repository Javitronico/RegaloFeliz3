using MediatR;
using RegaloFeliz.Application.Responses.Product;

namespace RegaloFeliz.Application.Products.Commands.UpdateProduct;

public class UpdateProductCommand : IRequest<UpdateProductDto>
{
    public UpdateProductCommand(long id, string name)
    {
        Id = id;
        Name = name;
    }
    public long Id { get; internal set; }

    public string Name { get; set; }
}
