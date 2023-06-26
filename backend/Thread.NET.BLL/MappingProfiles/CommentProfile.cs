using AutoMapper;
using Thread.NET.Common.DTO.Comment;
using Thread.NET.DAL.Entities;

namespace Thread.NET.BLL.MappingProfiles
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
