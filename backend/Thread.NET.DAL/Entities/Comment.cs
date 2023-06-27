using System.Collections.Generic;
using Thread.NET.DAL.Entities.Abstract;

namespace Thread.NET.DAL.Entities
{
    public sealed class Comment : BaseEntity
    {
        public Comment()
        {
            Reactions = new List<CommentReaction>();
        }

        public int AuthorId { get; set; }
        public User Author { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }

        public string Body { get; set; }

        public ICollection<CommentReaction> Reactions { get; private set; }
    }
}
