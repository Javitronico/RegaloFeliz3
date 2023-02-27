using MediatR;
using RegaloFeliz.Application.Responses;

namespace RegaloFeliz.Application.ProductSales.Commands.DeleteProductSale;

public class DeleteProductSaleCommand : IRequest<DeleteProductDto>
{
    public Guid Id { get; set; }

    public DeleteProductSaleCommand(Guid id) { Id = id; }
}
