using AutoMapper;
using Es.Locadora.Application.Models;
using Es.Locadora.Domain.Entities;

namespace Es.Locadora.Application.Mapping
{
    public class UserMap : Profile
    {
        public UserMap()
        {
            CreateMap<UserEntity, UserModel>().ReverseMap();
        }
    }
}
