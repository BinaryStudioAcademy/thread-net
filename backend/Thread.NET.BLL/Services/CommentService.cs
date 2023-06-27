using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Thread.NET.BLL.Services.Abstract;
using Thread.NET.Common.DTO.Comment;
using Thread.NET.DAL.Context;
using Thread.NET.DAL.Entities;

namespace Thread.NET.BLL.Services
{
    public sealed class CommentService : BaseService
    {
        public CommentService(ThreadContext context, IMapper mapper) : base(context, mapper) { }

        public async Task<CommentDTO> CreateComment(NewCommentDTO newComment)
        {
            var commentEntity = _mapper.Map<Comment>(newComment);

            _context.Comments.Add(commentEntity);
            await _context.SaveChangesAsync();

            var createdComment = await _context.Comments
                .Include(comment => comment.Author)
                    .ThenInclude(user => user.Avatar)
                .FirstAsync(comment => comment.Id == commentEntity.Id);

            return _mapper.Map<CommentDTO>(createdComment);
        }
    }
}
