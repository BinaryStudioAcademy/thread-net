using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
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
            var commentEntity = _mapper.Map<Comment>(newComment);

            _context.Comments.Add(commentEntity);
            await _context.SaveChangesAsync();

            var createdComment = await _context.Comments
                .Include(comment => comment.Author)
                    .ThenInclude(user => user.Avatar)
                .FirstAsync(comment => comment.Id == commentEntity.Id);

            return _mapper.Map<CommentDTO>(createdComment);
        }

        public async Task<bool> DeleteComment(int commentId)
        {
            var comment = await _context.Comments.Where(c => c.Id == commentId)
                .Include(c => c.Reactions)
                .FirstOrDefaultAsync();
            if (comment != null)
            {
                _context.CommentReactions.RemoveRange(comment.Reactions);
                _context.Comments.Remove(comment);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
