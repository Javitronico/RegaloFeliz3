using MediatR;
using RegaloFeliz.Application.Responses;

namespace RegaloFeliz.Application.Products.Commands.DeleteProduct
{
    public class DeleteProductCommand : IRequest<DeleteProductDto>
    {
        public Guid Id { get; set; }

        public DeleteProductCommand(Guid id) { Id = id; }


    }
}
