using Demo.CQRS.Mediator.Models;
using Demo.CQRS.Mediator.Queries.Request;
using Demo.CQRS.Mediator.Queries.Response;
using Demo.CQRS.Mediator.Repository.Interfaces;
using Raven.Client.Documents.Session;

namespace Demo.CQRS.Mediator.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IAsyncDocumentSession _session;

        public CustomerRepository(IAsyncDocumentSession session)
        {
            _session = session;
        }

        public async Task<FindCustomerByIdResponse> GetCustomerByIdAsync(FindCustomerByIdRequest command)
        {
            var result = await _session.LoadAsync<Customer>(command.Id.ToString());
            return new FindCustomerByIdResponse
            {
                Id = result.Id,
                Name = result.Name,
                Email = result.Email
            };
        }

        public async Task SaveAsync(Customer customer)
        {
            await _session.StoreAsync(customer);
            await _session.SaveChangesAsync();
        }
    }
}