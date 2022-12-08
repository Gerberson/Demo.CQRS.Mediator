using Demo.CQRS.Mediator.Queries.Response;
using MediatR;

namespace Demo.CQRS.Mediator.Queries.Request
{
    public class FindCustomerByIdRequest: IRequest<FindCustomerByIdResponse>
    {
        public Guid Id { get; set; }
    }
}