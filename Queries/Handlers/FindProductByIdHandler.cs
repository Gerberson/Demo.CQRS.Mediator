using Demo.CQRS.Mediator.Queries.Request;
using Demo.CQRS.Mediator.Queries.Response;
using Demo.CQRS.Mediator.Repository.Interfaces;
using MediatR;

namespace Demo.CQRS.Mediator.Queries.Handlers
{
    public class FindProductByIdHandler : IRequestHandler<FindProductByIdRequest, FindProductByIdResponse>
    {
        private readonly IProductRepository _repository;

        public FindProductByIdHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<FindProductByIdResponse> Handle(FindProductByIdRequest request, CancellationToken cancellationToken)
        {
            var result = await _repository.GetProductByIdAsync(request);
            return result;
        }
    }
}