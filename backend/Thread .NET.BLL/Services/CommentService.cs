using AutoMapper;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Thread_.NET.BLL.Services.Abstract;
using Thread_.NET.Common.DTO.Comment;
using Thread_.NET.DAL.Context;
using Thread_.NET.DAL.Entities;

namespace Thread_.NET.BLL.Services
{
    public sealed class CommentService : BaseService
    {
        public CommentService(ThreadContext context, IMapper mapper) : base(context, mapper) { }

        public async Task<CommentDTO> CreateComment(NewCommentDTO newComment)
        {
            var commentEntity = _mapper.Map<NewCommentDTO, Comment>(newComment);

            _context.Comments.Add(commentEntity);
            await _context.SaveChangesAsync();

            // Include Author info
            var author = await _context.Users.Include(x => x.Avatar).FirstAsync(x => x.Id == commentEntity.AuthorId);
            commentEntity.Author = author;

            return _mapper.Map<Comment, CommentDTO>(commentEntity);
        }
    }
}
