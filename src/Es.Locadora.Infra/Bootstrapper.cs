using Es.Locadora.Domain.Repositories.Interfaces;
using Es.Locadora.Infra.DapperMaper.Register;
using Es.Locadora.Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Es.Locadora.Infra
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddInfra(this IServiceCollection services)
        {
            services.TryAddScoped<IAccountRepository, AccountRepostory>();            
            RegisterMapTable.Register();

            return services;
        }
    }
}
