using System;

namespace Thread_.NET.DAL.Entities.Abstract
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            CreatedOn = ModifiedOn = DateTime.Now;
        }

        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
