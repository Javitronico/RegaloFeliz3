using MediatR;
using Microsoft.AspNetCore.Mvc;
using RegaloFeliz.Application.Products.Commands.CreateProduct;
using RegaloFeliz.Application.Products.Commands.DeleteProduct;
using RegaloFeliz.Application.Products.Commands.UpdateProduct;
using RegaloFeliz.Application.Products.Queries.GetProduct;
using RegaloFeliz.Application.Products.Queries.GetProducts;
using RegaloFeliz.Domain.DTOs.Requests.Product;

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

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _mediator.Send(new GetProductsQuery());

            if (products != null)
            {
                return Ok(products);
            }

            return NotFound("No products in database. Please add a product first.");
        }

        [HttpGet("/GetProduct/{id}")]
        public async Task<IActionResult> GetProduct(long id)
        {
            var product = await _mediator.Send(new GetProductQuery(id));

            if (product != null)
            {
                return Ok(product);
            }

            return NotFound($"No product in database with ID: {id}.");

        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductRequest request)
        {
            var product = await _mediator.Send(new CreateProductCommand(request.Name));

            return Ok(product);
        }

        [HttpDelete("/DeleteProduct/{id}")]
        public async Task<IActionResult> DeleteProduct(long id)
        {
            var product = await _mediator.Send(new DeleteProductCommand(id));

            return Ok(product);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct([FromBody] UpdateProductRequest request)
        {
            var product = await _mediator.Send(new UpdateProductCommand(request.Id, request.Name));

            return Ok(product);
        }


    }
}
