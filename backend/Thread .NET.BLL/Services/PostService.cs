using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thread_.NET.BLL.Hubs;
using Thread_.NET.BLL.Services.Abstract;
using Thread_.NET.Common.DTO.Post;
using Thread_.NET.DAL.Context;
using Thread_.NET.DAL.Entities;

namespace Thread_.NET.BLL.Services
{
    public sealed class PostService : BaseService
    {
        private readonly IHubContext<PostHub> _postHub;

        public PostService(ThreadContext context, IMapper mapper, IHubContext<PostHub> postHub) : base(context, mapper)
        {
            _postHub = postHub;
        }

        public async Task<ICollection<PostDTO>> GetAllPosts()
        {
            var posts = await _context.Posts
                .Include(post => post.Author)
                    .ThenInclude(author => author.Avatar)
                .Include(post => post.Preview)
                .Include(post => post.Reactions)
                    .ThenInclude(reaction => reaction.User)
                .Include(post => post.Comments)
                    .ThenInclude(comment => comment.Reactions)
                .Include(post => post.Comments)
                    .ThenInclude(comment => comment.Author)
                .OrderByDescending(post => post.CreatedAt)
                .ToListAsync();

            return _mapper.Map<ICollection<PostDTO>>(posts);
        }

        public async Task<ICollection<PostDTO>> GetAllPosts(int userId)
        {
            var posts = await _context.Posts
                .Include(post => post.Author)
                    .ThenInclude(author => author.Avatar)
                .Include(post => post.Preview)
                .Include(post => post.Comments)
                    .ThenInclude(comment => comment.Author)
                .Where(p => p.AuthorId == userId) // Filter here
                .ToListAsync();

            return _mapper.Map<ICollection<PostDTO>>(posts);
        }

        public async Task<PostDTO> CreatePost(PostCreateDTO postDto)
        {
            var postEntity = _mapper.Map<Post>(postDto);

            _context.Posts.Add(postEntity);
            await _context.SaveChangesAsync();

            var createdPost = await _context.Posts
                .Include(post => post.Author)
					.ThenInclude(author => author.Avatar)
                .FirstAsync(post => post.Id == postEntity.Id);

            var createdPostDTO = _mapper.Map<PostDTO>(createdPost);
            await _postHub.Clients.All.SendAsync("NewPost", createdPostDTO);

            return createdPostDTO;
        }

        public async Task<int> UpdatePost(PostDTO dto)
        {
            var postEntity = _mapper.Map<Post>(dto);
            var oldPost = await _context.Posts
                .Where(p => p.Id == postEntity.Id)
                .FirstOrDefaultAsync();
            if (oldPost == null) return 0;
            oldPost.Body = postEntity.Body;
            oldPost.Preview = postEntity.Preview;
            oldPost.UpdatedAt = postEntity.UpdatedAt;
            return await _context.SaveChangesAsync();
        }

        public async Task<bool> DeletePost(int postId)
        {
            var post = await _context.Posts
                .Include(post => post.Comments)
                    .ThenInclude(comment => comment.Reactions)
                .Include(post => post.Reactions)
                .Include(post => post.Preview)
                .FirstAsync(post => post.Id == postId);

            if (post == null) return false;
            {
                if (post.Comments.Count > 0)
                {
                    foreach (var comment in post.Comments)
                    {
                        if (comment.Reactions.Count > 0)    
                            _context.CommentReactions.RemoveRange(comment.Reactions);
                        _context.Comments.Remove(comment);
                    }
                }

                if (post.Reactions.Count > 0)
                    _context.PostReactions.RemoveRange(post.Reactions);

                if (post.Preview != null)
                    _context.Images.Remove(post.Preview);

                _context.Posts.Remove(post);
                await _context.SaveChangesAsync();
                return true;
            }
        }
    }
}
