using System.Collections.Generic;
using Thread_.NET.DAL.Entities.Abstract;

namespace Thread_.NET.DAL.Entities
{
    public class Comment : BaseEntity
    {
        public Comment()
        {
            Reactions = new List<LikeableEntity>();
        }

        public User Author { get; set; }
        public Post Post { get; set; }

        public string Body { get; set; }

        public ICollection<LikeableEntity> Reactions { get; private set; }
    }
}
