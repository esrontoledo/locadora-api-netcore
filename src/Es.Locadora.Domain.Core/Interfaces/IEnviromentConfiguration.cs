namespace Es.Locadora.Domain.Core.Interfaces
{
    public interface IEnviromentConfiguration
    {
        string Secret { get; }
        string ConnectionString { get; }
    }
}
