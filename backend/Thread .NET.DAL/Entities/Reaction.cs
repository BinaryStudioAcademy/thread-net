using Thread_.NET.DAL.Entities.Abstract;

namespace Thread_.NET.DAL.Entities
{
    public enum ReactionTo
    {
        Comment = 1,
        Post
    }

    public class Reaction : BaseEntity
    {
        public bool IsLike { get; set; }
        public User User { get; set; }
    }
}
