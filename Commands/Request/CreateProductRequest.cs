using Demo.CQRS.Mediator.Commands.Response;
using MediatR;

namespace Demo.CQRS.Mediator.Commands.Request
{
    public class CreateProductRequest : IRequest<CreateProductResponse>
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}