using Bogus;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Thread_.NET.DAL.Entities;

namespace Thread_.NET.DAL.Context
{
    public static class ModelBuilderExtensions
    {
        private static readonly int ENTITY_COUNT = 20;

        public static void Configure(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostReaction>()
                .HasOne(pr => pr.Post)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CommentReaction>()
                .HasOne(pr => pr.Comment)
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
            var reactions = GenerateRandomReactions(users);
            var comments = GenerateRandomComments(users, posts);
            var postReactions = GenerateRandomPostReactions(reactions, posts);
            var commentReactions = GenerateRandomCommentReactions(reactions, comments);

            modelBuilder.Entity<Image>().HasData(avatars.Concat(previewImages));
            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Post>().HasData(posts);
            modelBuilder.Entity<Reaction>().HasData(reactions);
            modelBuilder.Entity<Comment>().HasData(comments);
            modelBuilder.Entity<PostReaction>().HasData(postReactions);
            modelBuilder.Entity<CommentReaction>().HasData(commentReactions);
        }

        public static ICollection<Image> GenerateRandomAvatars(out int lastImageId)
        {
            int avatarImageId = 1;

            var avatarImagesFake = new Faker<Image>()
               .RuleFor(pi => pi.Id, f => avatarImageId++)
               .RuleFor(pi => pi.URL, f => f.Internet.Avatar());

            var avatarImages = avatarImagesFake.Generate(ENTITY_COUNT);
            lastImageId = avatarImageId; // lastImageId will be used to continue generating Images

            return avatarImages;
        }

        public static ICollection<Image> GenerateRandomPreviewImages(int lastImageId)
        {
            var previewImagesFake = new Faker<Image>()
                .RuleFor(pi => pi.Id, f => lastImageId++)
                .RuleFor(pi => pi.URL, f => f.Image.PicsumUrl());

            return previewImagesFake.Generate(ENTITY_COUNT);
        }

        public static ICollection<User> GenerateRandomUsers(ICollection<Image> avatars)
        {
            int userId = 1;

            var testUsersFake = new Faker<User>()
                .RuleFor(u => u.Id, f => userId++)
                .RuleFor(u => u.UserName, f => f.Internet.UserName())
                .RuleFor(u => u.Email, f => f.Internet.Email())
                .RuleFor(u => u.Password, f => f.Internet.Password(8))
                .RuleFor(u => u.AvatarId, f => f.PickRandom(avatars).Id);

            return testUsersFake.Generate(ENTITY_COUNT);
        }

        public static ICollection<Post> GenerateRandomPosts(ICollection<User> randomUsers, ICollection<Image> previewImages)
        {
            int postId = 1;

            var postsFake = new Faker<Post>()
                .RuleFor(p => p.Id, f => postId++)
                .RuleFor(p => p.Body, f => f.Lorem.Text())
                .RuleFor(p => p.PreviewId, f => f.PickRandom(previewImages).Id)
                .RuleFor(p => p.AuthorId, f => f.PickRandom(randomUsers).Id);

            return postsFake.Generate(ENTITY_COUNT);
        }

        public static ICollection<Comment> GenerateRandomComments(ICollection<User> users, ICollection<Post> posts)
        {
            int commentId = 1;

            var commentsFake = new Faker<Comment>()
                .RuleFor(c => c.Id, f => commentId++)
                .RuleFor(c => c.Body, f => f.Lorem.Sentence())
                .RuleFor(c => c.AuthorId, f => f.PickRandom(users).Id)
                .RuleFor(c => c.PostId, f => f.PickRandom(posts).Id);

            return commentsFake.Generate(ENTITY_COUNT);
        }

        public static ICollection<Reaction> GenerateRandomReactions(ICollection<User> users)
        {
            int reactionId = 1;

            var reactionsFake = new Faker<Reaction>()
                .RuleFor(r => r.Id, f => reactionId++)
                .RuleFor(r => r.IsLike, f => f.Random.Bool())
                .RuleFor(r => r.UserId, f => f.PickRandom(users).Id);

            return reactionsFake.Generate(ENTITY_COUNT);
        }

        public static ICollection<PostReaction> GenerateRandomPostReactions(ICollection<Reaction> reactions, ICollection<Post> posts)
        {
            int postReactionId = 1;

            var postReactionsFake = new Faker<PostReaction>()
                .RuleFor(pr => pr.Id, f => postReactionId++)
                .RuleFor(pr => pr.ReactionId, f => f.PickRandom(reactions).Id)
                .RuleFor(pr => pr.PostId, f => f.PickRandom(posts).Id);

            return postReactionsFake.Generate(ENTITY_COUNT);
        }

        public static ICollection<CommentReaction> GenerateRandomCommentReactions(ICollection<Reaction> reactions, ICollection<Comment> comments)
        {
            int commentReactionId = 1;

            var commentReactionsFake = new Faker<CommentReaction>()
                .RuleFor(pr => pr.Id, f => commentReactionId++)
                .RuleFor(pr => pr.ReactionId, f => f.PickRandom(reactions).Id)
                .RuleFor(pr => pr.CommentId, f => f.PickRandom(comments).Id);

            return commentReactionsFake.Generate(ENTITY_COUNT);
        }
    }
}
