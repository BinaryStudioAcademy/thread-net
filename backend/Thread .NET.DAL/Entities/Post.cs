using System.Collections.Generic;
using Thread_.NET.DAL.Entities.Abstract;

namespace Thread_.NET.DAL.Entities
{
    public class Post : BaseEntity
    {
        public Post()
        {
            Comments = new List<Comment>();
        }

        public User Author { get; set; }
        public Image Preview { get; set; }

        public string Body { get; set; }

        public List<Comment> Comments { get; private set; }
    }
}
