using Thread_.NET.DAL.Entities.Abstract;

namespace Thread_.NET.DAL.Entities
{
    public class CommentReaction: BaseEntity
    {
        public int ReactionId { get; set; }
        public Reaction Reaction { get; set; }

        public int CommentId { get; set; }
        public Comment Comment { get; set; }
    }
}
