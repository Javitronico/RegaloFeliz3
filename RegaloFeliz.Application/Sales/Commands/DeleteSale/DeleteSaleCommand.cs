using MediatR;
using RegaloFeliz.Application.Responses;

namespace RegaloFeliz.Application.Sales.Commands.DeleteSale
{
    public class DeleteSaleCommand : IRequest<DeleteSaleDto>
    {
        public DeleteSaleCommand(Guid id) { Id = id; }

        public Guid Id { get; set; }
    }
}
