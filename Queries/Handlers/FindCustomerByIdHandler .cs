using Demo.CQRS.Mediator.Queries.Request;
using Demo.CQRS.Mediator.Queries.Response;
using Demo.CQRS.Mediator.Repository.Interfaces;
using MediatR;

namespace Demo.CQRS.Mediator.Queries.Handlers
{
    public class FindCustomerByIdHandler : IRequestHandler<FindCustomerByIdRequest, FindCustomerByIdResponse>
    {
        private readonly ICustomerRepository _repository;

        public FindCustomerByIdHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<FindCustomerByIdResponse> Handle(FindCustomerByIdRequest request, CancellationToken cancellationToken)
        {
            var result = await _repository.GetCustomerByIdAsync(request);

            return result;
        }
    }
}