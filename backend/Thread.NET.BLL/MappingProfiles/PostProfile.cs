using AutoMapper;
using Thread.NET.Common.DTO.Post;
using Thread.NET.DAL.Entities;

namespace Thread.NET.BLL.MappingProfiles
{
    public sealed class PostProfile : Profile
    {
        public PostProfile()
        {
            CreateMap<Post, PostDTO>()
                .ForMember(dest => dest.PreviewImage, src => src.MapFrom(x => x.Preview != null ? x.Preview.URL : string.Empty));

            CreateMap<PostCreateDTO, Post>()
                .ForMember(dest => dest.Preview, src => src.MapFrom(s => string.IsNullOrEmpty(s.PreviewImage) ? null : new Image { URL = s.PreviewImage }));
        }
    }
}
