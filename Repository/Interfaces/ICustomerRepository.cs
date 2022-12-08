using Demo.CQRS.Mediator.Models;
using Demo.CQRS.Mediator.Queries.Request;
using Demo.CQRS.Mediator.Queries.Response;

namespace Demo.CQRS.Mediator.Repository.Interfaces
{
    public interface ICustomerRepository
    {
        Task SaveAsync(Customer customer);
        Task<FindCustomerByIdResponse> GetCustomerByIdAsync(FindCustomerByIdRequest command);
    }
}