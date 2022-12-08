using Demo.CQRS.Mediator.Models;
using Demo.CQRS.Mediator.Queries.Request;
using Demo.CQRS.Mediator.Queries.Response;
using Demo.CQRS.Mediator.Repository.Interfaces;
using Raven.Client.Documents.Session;

namespace Demo.CQRS.Mediator.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IAsyncDocumentSession _session;

        public ProductRepository(IAsyncDocumentSession session)
        {
            _session = session;
        }

        public async Task<FindProductByIdResponse> GetProductByIdAsync(FindProductByIdRequest command)
        {
            var result = await _session.LoadAsync<Product>(command.Id.ToString());
            return new FindProductByIdResponse
            {
                Id = result.Id,
                Name = result.Name
            };
        }

        public async Task SaveAsync(Product product)
        {
            await _session.StoreAsync(product);
            await _session.SaveChangesAsync();
        }
    }
}