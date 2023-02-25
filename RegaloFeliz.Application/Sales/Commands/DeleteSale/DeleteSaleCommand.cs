using MediatR;
using RegaloFeliz.Application.Responses.Sale;

namespace RegaloFeliz.Application.Sales.Commands.DeleteSale
{
    public class DeleteSaleCommand : IRequest<DeleteSaleDto>
    {
        public DeleteSaleCommand(long id) { Id = id; }

        public long Id { get; set; }
    }
}
