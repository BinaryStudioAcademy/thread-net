using AutoMapper;
using Thread_.NET.Common.DTOs;
using Thread_.NET.DAL.Entities;

namespace Thread_.NET.BLL.MappingProfiles
{
    public sealed class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
        }
    }
}
