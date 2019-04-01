using Thread_.NET.DAL.Entities.Abstract;

namespace Thread_.NET.DAL.Entities
{
    public class User : BaseEntity
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Image Avatar { get; set; }
    }
}
