using Demo.CQRS.Mediator.Models;
using Demo.CQRS.Mediator.Queries.Request;
using Demo.CQRS.Mediator.Queries.Response;

namespace Demo.CQRS.Mediator.Repository.Interfaces
{
    public interface IProductRepository
    {
        Task SaveAsync(Product product);
        Task<FindProductByIdResponse> GetProductByIdAsync(FindProductByIdRequest command);
    }
}