using AutoMapper;
using Thread_.NET.Common.DTO.Comment;
using Thread_.NET.DAL.Entities;

namespace Thread_.NET.BLL.MappingProfiles
{
    public sealed class CommentProfile : Profile
    {
        public CommentProfile()
        {
            CreateMap<Comment, CommentDTO>();

            CreateMap<NewCommentDTO, Comment>();
        }
    }
}
