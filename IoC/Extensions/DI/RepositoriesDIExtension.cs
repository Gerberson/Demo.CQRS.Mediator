using Demo.CQRS.Mediator.Repository;
using Demo.CQRS.Mediator.Repository.Interfaces;

namespace Demo.CQRS.Mediator.IoC.Extensions.DI
{
    public static class RepositoriesDIExtension
    {
        public static IServiceCollection AddRespositoriesDI(this IServiceCollection services)
        {
            services
                .AddScoped<IProductRepository, ProductRepository>()
                .AddScoped<ICustomerRepository, CustomerRepository>();

            return services;
        }
    }
}