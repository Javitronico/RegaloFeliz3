using MediatR;
using Microsoft.AspNetCore.Mvc;
using RegaloFeliz.Application.Products.Commands.CreateProduct;
using RegaloFeliz.Application.Products.Commands.DeleteProduct;
using RegaloFeliz.Application.Products.Commands.UpdateProduct;
using RegaloFeliz.Application.Products.Queries.GetProduct;
using RegaloFeliz.Application.Products.Queries.GetProducts;
using RegaloFeliz.Application.Requests;

namespace RegaloFeliz.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("/GetAllProducts")]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _mediator.Send(new GetProductsQuery());

            if (products == null)
            {
                return StatusCode(StatusCodes.Status204NoContent, "No products in database.");
            }

            return StatusCode(StatusCodes.Status200OK, products);
        }

        [HttpGet("/GetProductById/{id}")]
        public async Task<IActionResult> GetProduct(Guid id)
        {
            var product = await _mediator.Send(new GetProductQuery(id));

            if (product == null)
            {
                return StatusCode(StatusCodes.Status204NoContent, $"No product found for id: {id}.");
            }

            return StatusCode(StatusCodes.Status200OK, product);
        }

        [HttpPost("/CreateProduct")]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductRequest request)
        {
            var product = await _mediator.Send(new CreateProductCommand(request.Name));

            if (product == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"{request.Name} could not be created.");
            }

            return CreatedAtAction("CreateProduct", product);
        }

        [HttpPut("/UpdateProduct")]
        public async Task<IActionResult> UpdateProduct([FromBody] UpdateProductRequest request)
        {
            var product = await _mediator.Send(new UpdateProductCommand(request.Id, request.Name));

            if (product == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"{request.Id} could not be updated.");
            }

            return NoContent();
        }

        [HttpDelete("/DeleteProductById/{id}")]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            var product = await _mediator.Send(new DeleteProductCommand(id));

            if (product == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"{id} could not be deleted.");
            }

            return StatusCode(StatusCodes.Status200OK);
        }
    }
}
