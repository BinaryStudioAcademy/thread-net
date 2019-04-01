using Microsoft.EntityFrameworkCore;
using Thread_.NET.DAL.Entities;

namespace Thread_.NET.DAL.Context
{
    public class ThreadContext : DbContext
    {
        public ThreadContext(DbContextOptions<ThreadContext> options) : base(options) { }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<LikeableEntity> LikeableEntities { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LikeableEntity>()
                .HasOne(p => p.Comment).WithMany(c => c.Reactions).HasForeignKey(p => p.ParentId);

            modelBuilder.Entity<LikeableEntity>()
                .HasOne(p => p.Post).WithMany(p => p.Reactions).HasForeignKey(p => p.ParentId);
        }
    }
}
