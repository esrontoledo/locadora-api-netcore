using Es.Locadora.Application.Models;
using OP.MarketplacePeca.Automatizador.Application;
using System.Threading.Tasks;

namespace Es.Locadora.Application.Interfaces
{
    public interface IAccountApplication
    {
        Task<Result<UserModel>> LoginAsyc(string username, string password);
    }
}
