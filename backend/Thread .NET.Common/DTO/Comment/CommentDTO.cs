using System;
using Thread_.NET.Common.DTO.User;

namespace Thread_.NET.Common.DTO.Comment
{
    public sealed class CommentDTO
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public UserDTO Author { get; set; }
        public string Body { get; set; }
    }
}
