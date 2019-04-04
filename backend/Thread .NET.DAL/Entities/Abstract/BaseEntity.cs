using System;

namespace Thread_.NET.DAL.Entities.Abstract
{
    public abstract class BaseEntity
    {
        private DateTime _createdAt;

        public BaseEntity()
        {
            UpdatedAt = DateTime.Now;
        }

        public int Id { get; set; }
        public DateTime CreatedAt
        {
            get => _createdAt;
            set => _createdAt = value == null ? DateTime.Now : value;
        }
        public DateTime UpdatedAt { get; set; }
    }
}
