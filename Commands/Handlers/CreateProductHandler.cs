using Demo.CQRS.Mediator.Commands.Request;
using Demo.CQRS.Mediator.Commands.Response;
using Demo.CQRS.Mediator.Models;
using Demo.CQRS.Mediator.Repository.Interfaces;
using MediatR;

namespace Demo.CQRS.Mediator.Commands.Handlers
{
    public class CreateProductHandler : IRequestHandler<CreateProductRequest, CreateProductResponse>
    {
        private readonly IProductRepository _productRepository;

        public CreateProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<CreateProductResponse> Handle(CreateProductRequest request, CancellationToken cancellationToken)
        {
            var product = new Product(request.Name, request.Price);

            await _productRepository.SaveAsync(product);
            
            var result = new CreateProductResponse
            {
                Name = product.Name
            };

            return result;
        }
    }
}