using Thread_.NET.DAL.Entities.Abstract;

namespace Thread_.NET.DAL.Entities
{
    public class PostReaction: BaseEntity
    {
        public int ReactionId { get; set; }
        public Reaction Reaction { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
