using Es.Locadora.Application;
using Es.Locadora.Domain.Core;
using Es.Locadora.Infra;
using Microsoft.Extensions.DependencyInjection;

namespace Es.Locadora.CrossCutting.IoC
{
    public static class DependencyResolver
    {
        public static IServiceCollection AddDependencyResolver(this IServiceCollection services)
        {
            services.AddApplication();
            services.AddDomaisService();
            services.AddInfra();
            return services;
        }
    }
}
