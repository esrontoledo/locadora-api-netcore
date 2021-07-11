using Dapper.FluentMap.Dommel.Mapping;
using Es.Locadora.Domain.Entities;

namespace Es.Locadora.Infra.DapperMaper
{
    public class UserDapperMap : DommelEntityMap<UserEntity>
    {
        public UserDapperMap()
        {
            ToTable("User");
            Map(u => u.Id).ToColumn("Id").IsKey().IsIdentity();
            Map(u => u.Username).ToColumn("Username");
            Map(u => u.Password).ToColumn("Password");
            Map(u => u.Role).ToColumn("Role");
        }
    }
}
