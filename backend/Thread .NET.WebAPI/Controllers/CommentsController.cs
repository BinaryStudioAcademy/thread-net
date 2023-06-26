using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Thread_.NET.BLL.Services;
using Thread_.NET.Common.DTO.Comment;
using Thread_.NET.Common.Logic.Abstractions;
using Thread_.NET.Extensions;

namespace Thread_.NET.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly CommentService _commentService;
        private readonly IUserIdGetter _userIdGetter;

        public CommentsController(CommentService commentService, IUserIdGetter userIdGetter)
        {
            _commentService = commentService;
            _userIdGetter = userIdGetter;
        }

        /// <summary>
        /// Adds new comment to post
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<CommentDTO>> CreatePost([FromBody] NewCommentDTO comment)
        {
            comment.AuthorId = _userIdGetter.CurrentUserId;
            return Ok(await _commentService.CreateComment(comment));
        }
    }
}