using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Thread.NET.BLL.Services;
using Thread.NET.Common.DTO.Like;
using Thread.NET.Common.DTO.Post;
using Thread.NET.Common.Logic.Abstractions;
using Thread.NET.Extensions;

namespace Thread.NET.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly PostService _postService;
        private readonly LikeService _likeService;
        private readonly IUserIdGetter _userIdGetter;

        public PostsController(PostService postService, LikeService likeService, IUserIdGetter userIdGetter)
        {
            _postService = postService;
            _likeService = likeService;
            _userIdGetter = userIdGetter;
        }

        /// <summary>
        /// Get all existing posts
        /// </summary>
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<ICollection<PostDTO>>> Get()
        {
            return Ok(await _postService.GetAllPosts());
        }

        /// <summary>
        /// Create new post for all users
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<PostDTO>> CreatePost([FromBody] PostCreateDTO dto)
        {
            dto.AuthorId = _userIdGetter.CurrentUserId;

            return Ok(await _postService.CreatePost(dto));
        }

        /// <summary>
        /// Add like reaction to post
        /// </summary>
        [HttpPost("like")]
        public async Task<IActionResult> LikePost(NewReactionDTO reaction)
        {
            reaction.UserId = _userIdGetter.CurrentUserId;

            await _likeService.LikePost(reaction);
            return Ok();
        }
    }
}