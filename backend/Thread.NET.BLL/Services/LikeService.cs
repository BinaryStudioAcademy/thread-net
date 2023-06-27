﻿using AutoMapper;
using System.Linq;
using System.Threading.Tasks;
using Thread.NET.BLL.Services.Abstract;
using Thread.NET.Common.DTO.Like;
using Thread.NET.DAL.Context;

namespace Thread.NET.BLL.Services
{
    public sealed class LikeService : BaseService
    {
        public LikeService(ThreadContext context, IMapper mapper) : base(context, mapper) { }

        public async Task LikePost(NewReactionDTO reaction)
        {
            var likes = _context.PostReactions.Where(x => x.UserId == reaction.UserId && x.PostId == reaction.EntityId);

            if (likes.Any())
            {
                _context.PostReactions.RemoveRange(likes);
                await _context.SaveChangesAsync();

                return;
            }

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
