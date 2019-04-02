using System;

namespace Thread_.NET.DAL.Entities.Abstract
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            CreatedAt = UpdatedAt = DateTime.Now;
        }

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
