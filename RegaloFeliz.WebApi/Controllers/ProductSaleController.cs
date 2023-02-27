using MediatR;
using Microsoft.AspNetCore.Mvc;
using RegaloFeliz.Application.Commands.CreateProductSale;
using RegaloFeliz.Application.ProductSales.Commands.DeleteProductSale;
using RegaloFeliz.Application.ProductSales.Commands.UpdateProductSale;
using RegaloFeliz.Application.ProductSales.Queries.GetProductSale;
using RegaloFeliz.Application.ProductSales.Queries.GetProductSales;
using RegaloFeliz.Application.Requests;

namespace RegaloFeliz.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductSaleController : Controller
    {
        private readonly IMediator _mediator;

        public ProductSaleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("/GetAllProductSales")]
        public async Task<IActionResult> GetAllProductSales()
        {
            var productSales = await _mediator.Send(new GetProductSalesQuery());

            if (productSales == null) return NotFound("No product sales in database. Please add a product sale first."); ;

            return Ok(productSales);
        }

        [HttpGet("/GetProductSalesById/{id}")]
        public async Task<IActionResult> GetProductSale(Guid id)
        {
            var productSale = await _mediator.Send(new GetProductSaleQuery(id));

            if (productSale == null)
            {
                return StatusCode(StatusCodes.Status204NoContent, $"No product sale found for id: {id}.");
            }

            return StatusCode(StatusCodes.Status200OK, productSale);
        }

        [HttpPost("/CreateProductSale")]
        public async Task<IActionResult> CreateProductSale([FromBody] CreateProductSaleRequest request)
        {
            var productSale = await _mediator.Send(new CreateProductSaleCommand(request.ProductId, request.SaleId, request.Price));

            if (productSale == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"{request.ProductId} could not be created.");
            }

            return CreatedAtAction("CreateProductSale", productSale);
        }

        [HttpPut("/UpdateProductSale")]
        public async Task<IActionResult> UpdateProductSale([FromBody] UpdateProductSaleRequest request)
        {
            var product = await _mediator.Send(new UpdateProductSaleCommand(request.Id, request.ProductId, request.SaleId, request.Price));

            if (product == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"{request.Id} could not be updated.");
            }

            return NoContent();
        }

        [HttpDelete("/DeleteProductSaleById/{id}")]
        public async Task<IActionResult> DeleteProductSale(Guid id)
        {
            var productSale = await _mediator.Send(new DeleteProductSaleCommand(id));

            if (productSale == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"{id} could not be deleted.");
            }

            return StatusCode(StatusCodes.Status200OK);
        }
    }
}
