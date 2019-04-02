using Thread_.NET.DAL.Entities.Abstract;

namespace Thread_.NET.DAL.Entities
{
    public class Reaction : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public bool IsLike { get; set; }
    }
}
