using Demo.CQRS.Mediator.Services;
using Demo.CQRS.Mediator.Services.Interfaces;

namespace Demo.CQRS.Mediator.IoC.Extensions.DI
{
    public static class ServicesDIExtension
    {
        public static IServiceCollection AddServicesDI(this IServiceCollection services)
        {
            services
                .AddScoped<IEmailService, EmailService>();

            return services;
        }
    }
}