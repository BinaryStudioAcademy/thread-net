using System.Collections.Generic;
using Thread_.NET.DAL.Entities.Abstract;

namespace Thread_.NET.DAL.Entities
{
    public class Post : BaseEntity
    {
        public Post()
        {
            Comments = new List<Comment>();
            Reactions = new List<LikeableEntity>();
        }

        public User Author { get; set; }
        public Image Preview { get; set; }

        public string Body { get; set; }

        public ICollection<Comment> Comments { get; private set; }
        public ICollection<LikeableEntity> Reactions { get; private set; }
    }
}
