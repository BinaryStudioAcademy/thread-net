using AutoMapper;
using Thread_.NET.Common.DTOs;
using Thread_.NET.DAL.Entities;

namespace Thread_.NET.BLL.AutoMapper.MappingProfiles
{
    public sealed class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>()
               .ForMember(dest => dest.Avatar, src => src.MapFrom<UserDTOAvatarResolver>());

            CreateMap<UserDTO, User>()
                .ForMember(u => u.Avatar, dto => dto.MapFrom<UserAvatarResolver>());
        }
    }

    public sealed class UserDTOAvatarResolver : IValueResolver<User, UserDTO, string>
    {
        public string Resolve(User source, UserDTO destination, string destMember, ResolutionContext context) => source.Avatar?.URL;
    }

    public sealed class UserAvatarResolver : IValueResolver<UserDTO, User, Image>
    {
        public Image Resolve(UserDTO source, User destination, Image destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.Avatar))
            {
                return new Image
                {
                    URL = source.Avatar
                };
            }

            return null;
        }
    }
}
