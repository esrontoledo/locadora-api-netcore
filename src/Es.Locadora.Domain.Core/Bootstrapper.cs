using Es.Locadora.Domain.Core.Implementation;
using Es.Locadora.Domain.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Es.Locadora.Domain.Core
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddDomaisService(this IServiceCollection services)
        {
            services.TryAddScoped<IEnviromentConfiguration, EnviromentConfiguration>();
            return services;
        }
    }
}
