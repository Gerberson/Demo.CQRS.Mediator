using Demo.CQRS.Mediator.Commands.Handlers;
using Demo.CQRS.Mediator.Commands.Request;
using Demo.CQRS.Mediator.Commands.Response;
using Demo.CQRS.Mediator.Queries.Handlers;
using Demo.CQRS.Mediator.Queries.Request;
using Demo.CQRS.Mediator.Queries.Response;
using Demo.CQRS.Mediator.Request.Commands;
using MediatR;

namespace Demo.CQRS.Mediator.IoC.Extensions.DI
{
    public static class HandlersDIExtensions
    {
        public static IServiceCollection AddHandlersDI(this IServiceCollection services)
        {
            services
                .AddScoped<IRequestHandler<CreateProductRequest, CreateProductResponse>, CreateProductHandler>()
                .AddScoped<IRequestHandler<FindProductByIdRequest, FindProductByIdResponse>, FindProductByIdHandler>()
                .AddScoped<IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>, CreateCustomerHandler>()
                .AddScoped<IRequestHandler<FindCustomerByIdRequest, FindCustomerByIdResponse>, FindCustomerByIdHandler>();

            return services;
        }
    }
}