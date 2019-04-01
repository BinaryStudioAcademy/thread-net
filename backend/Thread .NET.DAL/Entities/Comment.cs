using Thread_.NET.DAL.Entities.Abstract;

namespace Thread_.NET.DAL.Entities
{
    public class Comment : BaseEntity
    {
        public User Author { get; set; }
        public Post Post { get; set; }

        public string Body { get; set; }
    }
}
