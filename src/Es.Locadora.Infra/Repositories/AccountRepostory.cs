using Es.Locadora.Domain.Core.Interfaces;
using Es.Locadora.Domain.Entities;
using Es.Locadora.Domain.Repositories.Interfaces;
using Es.Locadora.Infra.Repositories.Base;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Es.Locadora.Infra.Repositories
{
    public class AccountRepostory : BaseRepository<UserEntity>, IAccountRepository
    {
        public AccountRepostory(Lazy<SqlConnection> connectionString, IEnviromentConfiguration enviromentConfiguration) : base(connectionString, enviromentConfiguration) { }

        public Task<UserEntity> LoginAsync(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
