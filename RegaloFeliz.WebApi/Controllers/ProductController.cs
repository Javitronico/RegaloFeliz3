using MediatR;
using Microsoft.AspNetCore.Mvc;
using RegaloFeliz.Application.Products.Commands.CreateProduct;
using RegaloFeliz.Application.Products.Commands.DeleteProduct;
using RegaloFeliz.Application.Products.Commands.UpdateProduct;
using RegaloFeliz.Application.Products.Queries.GetProduct;
using RegaloFeliz.Application.Products.Queries.GetProducts;
using RegaloFeliz.Application.Requests.Product;

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

            if (products == null) return NotFound("No products in database. Please add a product first."); ;

            return Ok(products);
        }

        [HttpGet("/GetProductById/{id}")]
        public async Task<IActionResult> GetProduct(long id)
        {
            var product = await _mediator.Send(new GetProductQuery(id));

            if (product == null) return NotFound($"No product in database with ID: {id}.");

            return Ok(product);
        }

        [HttpPost("/CreateProduct")]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductRequest request)
        {
            var product = await _mediator.Send(new CreateProductCommand(request.Name));

            return Ok(product);
        }

        [HttpDelete("/DeleteProductById/{id}")]
        public async Task<IActionResult> DeleteProduct(long id)
        {
            var product = await _mediator.Send(new DeleteProductCommand(id));

            return Ok(product);
        }

        [HttpPut("/UpdateProduct")]
        public async Task<IActionResult> UpdateProduct([FromBody] UpdateProductRequest request)
        {
            var product = await _mediator.Send(new UpdateProductCommand(request.Id, request.Name));

            return Ok(product);
        }


    }
}
