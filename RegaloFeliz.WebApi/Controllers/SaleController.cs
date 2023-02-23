using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegaloFeliz.Application.Products.Commands.CreateProduct;
using RegaloFeliz.Application.Products.Commands.UpdateProduct;
using RegaloFeliz.Application.Products.Queries.GetProduct;
using RegaloFeliz.Application.Products.Queries.GetProducts;
using RegaloFeliz.Application.Requests.Sale;
using RegaloFeliz.Application.Sales.Commands.CreateSale;
using RegaloFeliz.Application.Sales.Commands.UpdateSale;
using RegaloFeliz.Application.Sales.Queries.GetSale;
using RegaloFeliz.Application.Sales.Queries.GetSales;
using RegaloFeliz.Domain.DTOs.Requests.Product;

namespace RegaloFeliz.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class SaleController : Controller
    {
        private readonly IMediator _mediator;

        public SaleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetSales(long id)
        {
            var sales = await _mediator.Send(new GetSalesQuery());

            if (sales == null) return NotFound("No sales in database. Please add a sale first.");

            return Ok(sales);
        }

        [HttpGet("/GetSale/{id}")]
        public async Task<IActionResult> GetSale(long id)
        {
            var sale = await _mediator.Send(new GetSaleQuery(id));

            if (sale!= null) return NotFound($"No sale in database with ID: {id}.");

            return Ok(sale);

        }

        [HttpPost]
        public async Task<ActionResult> CreateSale([FromBody] CreateSaleRequest request)
        {
            var sale = await _mediator.Send(new CreateSaleCommand(
                request.SaleDate,
                request.TotalAmount));

            return Ok(sale);

        }

        [HttpPut]
        public async Task<IActionResult> UpdateSale([FromBody] UpdateSaleRequest request)
        {
            var sale = await _mediator.Send(new UpdateSaleCommand(
                request.Id,
                request.SaleDate,
                request.TotalAmount));

            return Ok(sale);
        }
    }
}
