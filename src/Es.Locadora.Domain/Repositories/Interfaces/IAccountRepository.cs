using Es.Locadora.Domain.Entities;
using Es.Locadora.Domain.Repositories.Base;
using System.Threading.Tasks;

namespace Es.Locadora.Domain.Repositories.Interfaces
{
    public interface IAccountRepository : IBaseRepository<UserEntity>
    {
        Task<UserEntity> LoginAsync(string username, string password);
    }
}
