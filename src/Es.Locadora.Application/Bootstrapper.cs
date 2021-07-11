using Es.Locadora.Application.Implementation;
using Es.Locadora.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Es.Locadora.Application
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.TryAddScoped<ITokenApplication, TokenApplication>();
            return services;
        }
    }
}
