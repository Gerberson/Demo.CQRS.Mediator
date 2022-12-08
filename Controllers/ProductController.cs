using Demo.CQRS.Mediator.Commands.Request;
using Demo.CQRS.Mediator.Queries.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Demo.CQRS.Mediator.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetById([FromServices] IMediator mediator, [FromQuery] FindProductByIdRequest command)
        {
            var response = await mediator.Send(command);
            return Ok(response);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Create([FromServices] IMediator mediator, [FromBody] CreateProductRequest command)
        {
            var response = await mediator.Send(command);
            return Ok(response);
        }
    }
}