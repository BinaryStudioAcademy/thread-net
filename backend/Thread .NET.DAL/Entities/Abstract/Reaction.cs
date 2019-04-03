namespace Thread_.NET.DAL.Entities.Abstract
{
    public abstract class Reaction : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public bool IsLike { get; set; }
    }
}
