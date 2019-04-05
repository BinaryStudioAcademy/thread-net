using System;

namespace Thread_.NET.Common.DTOs.Abstract
{
    public abstract class BaseDTO
    {
        private DateTime _createdAt;

        public BaseDTO()
        {
            CreatedAt = UpdatedAt = DateTime.Now;
        }

        public int Id { get; set; }
        public DateTime CreatedAt
        {
            get => _createdAt;
            set => _createdAt = (value == null || value == DateTime.MinValue) ? DateTime.Now : value;
        }
        public DateTime UpdatedAt { get; set; }
    }
}
