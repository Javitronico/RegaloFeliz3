using MediatR;
using RegaloFeliz.Domain.DTOs.Responses.Product;

namespace RegaloFeliz.Application.Products.Commands.DeleteProduct
{
    public class DeleteProductCommand: IRequest<DeleteProductDto>
    {
        public DeleteProductCommand(long? id)
        {
            Id = id;
        }

        public long? Id { get; set; }
    }
}
