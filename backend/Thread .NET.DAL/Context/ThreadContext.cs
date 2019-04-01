using Microsoft.EntityFrameworkCore;
using Thread_.NET.DAL.Entities;

namespace Thread_.NET.DAL.Context
{
    public class ThreadContext : DbContext
    {
        public ThreadContext(DbContextOptions<ThreadContext> options) : base(options) { }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
