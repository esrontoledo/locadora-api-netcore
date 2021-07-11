using Es.Locadora.Application.Models;

namespace Es.Locadora.Application.Interfaces
{
    public interface ITokenApplication
    {
        string Generate(UserModel user);
    }
}
