using Demo.CQRS.Mediator.Queries.Request;
using Demo.CQRS.Mediator.Request.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Demo.CQRS.Mediator.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetById([FromServices] IMediator mediator, [FromQuery] FindCustomerByIdRequest command)
        {
            var response = await mediator.Send(command);
            return Ok(response);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Create([FromServices] IMediator mediator, [FromBody] CreateCustomerRequest command)
        {
            var response = await mediator.Send(command);
            return Ok(response);
        }
    }
}