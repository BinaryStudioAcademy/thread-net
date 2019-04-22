using AutoMapper;
using System.Threading.Tasks;
using Thread_.NET.BLL.Services.Abstract;
using Thread_.NET.Common.DTO.Like;
using Thread_.NET.DAL.Context;

namespace Thread_.NET.BLL.Services
{
    public sealed class LikeService : BaseService
    {
        public LikeService(ThreadContext context, IMapper mapper) : base(context, mapper) { }

        public async Task LikePost(NewReactionDTO reaction)
        {
            _context.PostReactions.Add(new DAL.Entities.PostReaction
            {
                PostId = reaction.EntityId,
                IsLike = reaction.IsLike,
                UserId = reaction.UserId
            });

            await _context.SaveChangesAsync();
        }
    }
}
