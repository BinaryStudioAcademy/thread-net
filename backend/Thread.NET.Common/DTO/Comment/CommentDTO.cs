using System;
using System.Collections.Generic;
using Thread.NET.Common.DTO.Like;
using Thread.NET.Common.DTO.User;

namespace Thread.NET.Common.DTO.Comment
{
    public sealed class CommentDTO
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public UserDTO Author { get; set; }
        public string Body { get; set; }

        public ICollection<ReactionDTO> Reactions { get; set; }
    }
}
