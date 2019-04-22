using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thread_.NET.BLL.Services.Abstract;
using Thread_.NET.Common.DTO.Post;
using Thread_.NET.DAL.Context;
using Thread_.NET.DAL.Entities;

namespace Thread_.NET.BLL.Services
{
    public sealed class PostService : BaseService
    {
        public PostService(ThreadContext context, IMapper mapper) : base(context, mapper) { }

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
                .ToListAsync();

            return _mapper.Map<ICollection<Post>, ICollection<PostDTO>>(posts);
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

            return _mapper.Map<ICollection<Post>, ICollection<PostDTO>>(posts);
        }

        public async Task<PostDTO> CreatePost(PostCreateDTO postDto)
        {
            var postEntity = _mapper.Map<PostCreateDTO, Post>(postDto);

            _context.Posts.Add(postEntity);
            await _context.SaveChangesAsync();

            // Include Author info
            var author = await _context.Users.FindAsync(postEntity.AuthorId);
            postEntity.Author = author;

            return _mapper.Map<Post, PostDTO>(postEntity);
        }
    }
}
