using AutoMapper;
using Thread_.NET.Common.DTO.User;
using Thread_.NET.DAL.Entities;

namespace Thread_.NET.BLL.MappingProfiles
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
