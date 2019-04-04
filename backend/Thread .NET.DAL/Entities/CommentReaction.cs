using Thread_.NET.DAL.Entities.Abstract;

namespace Thread_.NET.DAL.Entities
{
    public sealed class CommentReaction : Reaction
    {
        public int CommentId { get; set; }
        public Comment Comment { get; set; }
    }
}
