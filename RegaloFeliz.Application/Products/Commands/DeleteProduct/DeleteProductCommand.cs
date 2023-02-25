using MediatR;
using RegaloFeliz.Application.Responses.Product;

namespace RegaloFeliz.Application.Products.Commands.DeleteProduct
{
    public class DeleteProductCommand : IRequest<DeleteProductDto>
    {
        public DeleteProductCommand(long id) { Id = id; }

        public long Id { get; set; }
    }
}
