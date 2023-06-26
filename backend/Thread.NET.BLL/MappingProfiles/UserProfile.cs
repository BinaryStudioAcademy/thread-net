using AutoMapper;
using Thread.NET.Common.DTO.User;
using Thread.NET.DAL.Entities;

namespace Thread.NET.BLL.MappingProfiles
{
    public sealed class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>()
               .ForMember(dest => dest.Avatar, src => src.MapFrom(s => s.Avatar != null ? s.Avatar.URL : string.Empty));

            CreateMap<UserRegisterDTO, User>()
                .ForMember(dest => dest.Avatar, src => src.MapFrom(s => string.IsNullOrEmpty(s.Avatar) ? null : new Image { URL = s.Avatar }));
        }
    }
}
