using Demo.CQRS.Mediator.Commands.Response;
using Demo.CQRS.Mediator.Models;
using Demo.CQRS.Mediator.Repository.Interfaces;
using Demo.CQRS.Mediator.Request.Commands;
using Demo.CQRS.Mediator.Services.Interfaces;
using MediatR;

namespace Demo.CQRS.Mediator.Commands.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        ICustomerRepository _repository;
        IEmailService _emailService;

        public CreateCustomerHandler(ICustomerRepository repository, IEmailService emailService)
        {
            _repository = repository;
            _emailService = emailService;
        }

        public async Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            // Aplicar Fail Fast Validations

            // Cria a entidade
            var customer = new Customer(request.Name, request.Email);

            // Persiste a entidade no banco
            await _repository.SaveAsync(customer);

            // Envia E-mail de boas-vindas
            _emailService.Send(customer.Name, customer.Email);

            // Retorna a resposta
            var result = new CreateCustomerResponse
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
                Date = DateTime.Now
            };

            return result;
        }
    }
}