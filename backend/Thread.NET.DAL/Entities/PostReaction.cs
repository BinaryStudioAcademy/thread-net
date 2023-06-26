using Thread.NET.DAL.Entities.Abstract;

namespace Thread.NET.DAL.Entities
{
    public sealed class PostReaction: Reaction
    {
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
