using Thread_.NET.DAL.Entities.Abstract;

namespace Thread_.NET.DAL.Entities
{
    public class LikeableEntity : BaseEntity
    {
        public int ParentId { get; set; }

        public ReactionTo ReactionTo { get; set; }
        public Reaction Reaction { get; set; }

        public Comment Comment { get; set; }
        public Post Post { get; set; }
    }
}