using Design.Pattern.Behavioral.Mediator.Command;
using Design.Pattern.Behavioral.Mediator.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Design.Pattern.Behavioral.Mediator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductCommand command)
        {
            var response = await _mediator.Send(command);
            return response.Success ? Ok(response) : BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var response = await _mediator.Send(new GetAllProductsQuery());
            return Ok(response);
        }
    }
}
