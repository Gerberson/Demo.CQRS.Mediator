using Demo.CQRS.Mediator.Commands.Response;
using MediatR;

namespace Demo.CQRS.Mediator.Request.Commands
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}