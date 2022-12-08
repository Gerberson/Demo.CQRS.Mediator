using Demo.CQRS.Mediator.Queries.Response;
using MediatR;

namespace Demo.CQRS.Mediator.Queries.Request
{
    public class FindProductByIdRequest : IRequest<FindProductByIdResponse>
    {
        public Guid Id { get; set; }
    }
}