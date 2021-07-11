using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;

namespace Es.Locadora.Infra.DapperMaper.Register
{
    public static class RegisterMapTable
    {
        public static void Register()
        {
            FluentMapper.Initialize(config =>
            {
                config.AddMap(new UserDapperMap());
                config.ForDommel();
            });
        }
    }
}
