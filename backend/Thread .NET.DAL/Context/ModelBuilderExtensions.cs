using Bogus;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Thread_.NET.Common.Security;
using Thread_.NET.DAL.Entities;
using Thread_.NET.DAL.Entities.Abstract;

namespace Thread_.NET.DAL.Context
{
    public static class ModelBuilderExtensions
    {
        private const int ENTITY_COUNT = 20;

        public static void Configure(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RefreshToken>().Ignore(t => t.IsActive);

            modelBuilder.Entity<PostReaction>()
                .HasAlternateKey(pr => new { pr.PostId, pr.UserId });

            modelBuilder.Entity<PostReaction>()
                .HasOne(pr => pr.Post)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CommentReaction>()
                .HasAlternateKey(cr => new { cr.CommentId, cr.UserId });

            modelBuilder.Entity<CommentReaction>()
                .HasOne(cr => cr.Comment)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Post>()
                .HasMany(p => p.Comments)
                .WithOne(c => c.Post)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Post>()
                .HasOne(p => p.Preview)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Post>()
                .HasMany(p => p.Reactions)
                .WithOne(r => r.Post)
                .HasForeignKey(r => r.PostId);

            modelBuilder.Entity<Comment>()
                .HasMany(p => p.Reactions)
                .WithOne(r => r.Comment)
                .HasForeignKey(r => r.CommentId);
        }

        public static void Seed(this ModelBuilder modelBuilder)
        {
            var avatars = GenerateRandomAvatars(out int lastImageId);
            var previewImages = GenerateRandomPreviewImages(lastImageId);

            var users = GenerateRandomUsers(avatars);
            var posts = GenerateRandomPosts(users, previewImages);
            var comments = GenerateRandomComments(users, posts);
            var postReactions = GenerateRandomPostReactions(posts, users);
            var commentReactions = GenerateRandomCommentReactions(comments, users);

            modelBuilder.Entity<Image>().HasData(avatars.Concat(previewImages));
            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Post>().HasData(posts);
            modelBuilder.Entity<Comment>().HasData(comments);
            modelBuilder.Entity<PostReaction>().HasData(postReactions);
            modelBuilder.Entity<CommentReaction>().HasData(commentReactions);
        }

        public static ICollection<Image> GenerateRandomAvatars(out int lastImageId)
        {
            int avatarImageId = 1;

            var avatarImagesFake = new Faker<Image>()
               .RuleFor(pi => pi.Id, f => avatarImageId++)
               .RuleFor(pi => pi.URL, f => f.Internet.Avatar())
               .RuleFor(pi => pi.CreatedAt, f => DateTime.Now)
               .RuleFor(pi => pi.UpdatedAt, f => DateTime.Now);

            var avatarImages = avatarImagesFake.Generate(ENTITY_COUNT);
            lastImageId = avatarImageId; // lastImageId will be used to continue generating Images

            return avatarImages;
        }

        public static ICollection<Image> GenerateRandomPreviewImages(int lastImageId)
        {
            var previewImagesFake = new Faker<Image>()
                .RuleFor(pi => pi.Id, f => lastImageId++)
                .RuleFor(pi => pi.URL, f => f.Image.PicsumUrl())
                .RuleFor(pi => pi.CreatedAt, f => DateTime.Now)
                .RuleFor(pi => pi.UpdatedAt, f => DateTime.Now);

            return previewImagesFake.Generate(ENTITY_COUNT);
        }

        public static ICollection<User> GenerateRandomUsers(ICollection<Image> avatars)
        {
            int userId = 1;

            var testUsersFake = new Faker<User>()
                .RuleFor(u => u.Id, f => userId++)
                .RuleFor(u => u.UserName, f => f.Internet.UserName())
                .RuleFor(u => u.Email, f => f.Internet.Email())
                .RuleFor(u => u.Salt, f => Convert.ToBase64String(SecurityHelper.GetRandomBytes()))
                .RuleFor(u => u.Password, (f, u) => SecurityHelper.HashPassword(f.Internet.Password(12), Convert.FromBase64String(u.Salt)))
                .RuleFor(u => u.AvatarId, f => f.PickRandom(avatars).Id)
                .RuleFor(pi => pi.CreatedAt, f => DateTime.Now)
                .RuleFor(pi => pi.UpdatedAt, f => DateTime.Now);

            var generatedUsers = testUsersFake.Generate(ENTITY_COUNT);

            var salt = Convert.ToBase64String(SecurityHelper.GetRandomBytes());
            var hashedPassword = SecurityHelper.HashPassword("passw0rd", Convert.FromBase64String(salt));

            var myUser = new User
            {
                Id = userId,
                Email = "test@gmail.com",
                Password = hashedPassword,
                Salt = salt,
                UserName = "testUser"
            };

            generatedUsers.Add(myUser);

            return generatedUsers;
        }

        public static ICollection<Post> GenerateRandomPosts(ICollection<User> randomUsers, ICollection<Image> previewImages)
        {
            int postId = 1;

            var postsFake = new Faker<Post>()
                .RuleFor(p => p.Id, f => postId++)
                .RuleFor(p => p.Body, f => f.Lorem.Text())
                .RuleFor(p => p.PreviewId, f => f.PickRandom(previewImages).Id)
                .RuleFor(p => p.AuthorId, f => f.PickRandom(randomUsers).Id)
                .RuleFor(pi => pi.CreatedAt, f => DateTime.Now)
                .RuleFor(pi => pi.UpdatedAt, f => DateTime.Now);

            return postsFake.Generate(ENTITY_COUNT);
        }

        public static ICollection<Comment> GenerateRandomComments(ICollection<User> users, ICollection<Post> posts)
        {
            int commentId = 1;

            var commentsFake = new Faker<Comment>()
                .RuleFor(c => c.Id, f => commentId++)
                .RuleFor(c => c.Body, f => f.Lorem.Sentence())
                .RuleFor(c => c.AuthorId, f => f.PickRandom(users).Id)
                .RuleFor(c => c.PostId, f => f.PickRandom(posts).Id)
                .RuleFor(pi => pi.CreatedAt, f => DateTime.Now)
                .RuleFor(pi => pi.UpdatedAt, f => DateTime.Now);

            return commentsFake.Generate(ENTITY_COUNT);
        }

        public static ICollection<Reaction> GenerateRandomReactions(ICollection<User> users)
        {
            int reactionId = 1;

            var reactionsFake = new Faker<Reaction>()
                .RuleFor(r => r.Id, f => reactionId++)
                .RuleFor(r => r.IsLike, f => f.Random.Bool())
                .RuleFor(r => r.UserId, f => f.PickRandom(users).Id)
                .RuleFor(pi => pi.CreatedAt, f => DateTime.Now)
                .RuleFor(pi => pi.UpdatedAt, f => DateTime.Now);

            return reactionsFake.Generate(ENTITY_COUNT);
        }

        public static ICollection<PostReaction> GenerateRandomPostReactions(ICollection<Post> posts, ICollection<User> users)
        {
            int postReactionId = 1;

            var postReactionsFake = new Faker<PostReaction>()
                .RuleFor(pr => pr.Id, f => postReactionId++)
                .RuleFor(cr => cr.IsLike, f => f.Random.Bool())
                .RuleFor(cr => cr.UserId, f => f.PickRandom(users).Id)
                .RuleFor(pr => pr.PostId, f => f.PickRandom(posts).Id)
                .RuleFor(pi => pi.CreatedAt, f => DateTime.Now)
                .RuleFor(pi => pi.UpdatedAt, f => DateTime.Now);

            return postReactionsFake.Generate(ENTITY_COUNT);
        }

        public static ICollection<CommentReaction> GenerateRandomCommentReactions(ICollection<Comment> comments, ICollection<User> users)
        {
            int commentReactionId = 1;

            var commentReactionsFake = new Faker<CommentReaction>()
                .RuleFor(cr => cr.Id, f => commentReactionId++)
                .RuleFor(cr => cr.IsLike, f => f.Random.Bool())
                .RuleFor(cr => cr.UserId, f => f.PickRandom(users).Id)
                .RuleFor(cr => cr.CommentId, f => f.PickRandom(comments).Id)
                .RuleFor(pi => pi.CreatedAt, f => DateTime.Now)
                .RuleFor(pi => pi.UpdatedAt, f => DateTime.Now);

            return commentReactionsFake.Generate(ENTITY_COUNT);
        }
    }
}
