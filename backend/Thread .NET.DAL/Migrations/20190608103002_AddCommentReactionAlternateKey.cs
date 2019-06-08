using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Thread_.NET.DAL.Migrations
{
    public partial class AddCommentReactionAlternateKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CommentReactions_CommentId",
                table: "CommentReactions");

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_CommentReactions_CommentId_UserId",
                table: "CommentReactions",
                columns: new[] { "CommentId", "UserId" });

            migrationBuilder.InsertData(
                table: "CommentReactions",
                columns: new[] { "Id", "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 15, 20, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(1379), true, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(1396), 13 },
                    { 3, 14, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(115), false, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(127), 18 },
                    { 4, 18, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(208), true, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(224), 15 },
                    { 5, 18, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(305), true, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(321), 2 },
                    { 6, 8, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(402), false, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(419), 14 },
                    { 7, 10, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(504), false, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(520), 12 },
                    { 8, 1, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(666), true, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(682), 19 },
                    { 9, 3, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(779), false, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(796), 16 },
                    { 10, 13, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(881), true, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(897), 15 },
                    { 11, 18, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(978), false, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(994), 5 },
                    { 12, 20, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(1079), true, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(1096), 9 },
                    { 13, 6, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(1185), false, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(1197), 1 },
                    { 14, 18, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(1282), false, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(1298), 7 },
                    { 16, 4, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(1797), false, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(1821), 12 },
                    { 17, 17, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(1915), true, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(1931), 1 },
                    { 18, 7, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(2008), false, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(2024), 18 },
                    { 19, 2, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(2101), false, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(2113), 10 },
                    { 20, 11, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(2190), true, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(2202), 2 },
                    { 2, 18, new DateTime(2019, 6, 8, 13, 30, 1, 865, DateTimeKind.Local).AddTicks(9981), false, new DateTime(2019, 6, 8, 13, 30, 1, 866, DateTimeKind.Local).AddTicks(9), 6 },
                    { 1, 11, new DateTime(2019, 6, 8, 13, 30, 1, 865, DateTimeKind.Local).AddTicks(6993), false, new DateTime(2019, 6, 8, 13, 30, 1, 865, DateTimeKind.Local).AddTicks(8315), 21 }
                });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 16, "Et minus amet.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(961), 3, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 12, "Sit sint architecto.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(4079), 13, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(4119) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 8, "Ea ad deleniti ut quis officia voluptatibus occaecati.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(4379), 7, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 17, "In eius qui necessitatibus et sapiente quis iure.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(4626), 16, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 8, "Dolor doloremque est rerum et quis.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(4837), 8, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 19, "Tenetur occaecati omnis dolorem molestiae.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(5039), 6, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(5056) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 11, "Ut tempore ut id et odit temporibus.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(5295), 7, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(5315) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 18, "Qui iste temporibus dolores.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(5494), 20, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(5514) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 19, "Dolores ducimus magni qui nesciunt est quia aut a tempore.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(5729), 10, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(5749) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 19, "Delectus non nihil cumque sed dolores ut impedit.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(5952), 19, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 10, "Consequuntur odit tempora omnis vel sunt illum nobis et quia.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(6195), 10, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(6211) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 17, "At aut veritatis veritatis.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(6402), 20, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(6418) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 2, "Voluptates inventore libero sit illo pariatur.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(6657), 1, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(6677) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 9, "Quam magnam quidem cupiditate ratione id ab eum.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(6904), 4, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(6925) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 13, "At adipisci expedita dignissimos provident architecto.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(7119), 17, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 19, "Architecto deleniti earum.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(7285), 10, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(7302) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 15, "Quasi iusto ipsa.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(7460), 20, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 21, "Aut maiores eum a quibusdam non.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(7837), 6, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(7861) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 13, "Soluta est animi.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(8072), 12, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(8092) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 20, "In tempora et voluptatibus ut et consequatur fuga.", new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(8287), 7, new DateTime(2019, 6, 8, 13, 30, 1, 827, DateTimeKind.Local).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 425, DateTimeKind.Local).AddTicks(742), "https://s3.amazonaws.com/uifaces/faces/twitter/exentrich/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(2661) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(5920), "https://s3.amazonaws.com/uifaces/faces/twitter/kolage/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6046), "https://s3.amazonaws.com/uifaces/faces/twitter/joshaustin/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6127), "https://s3.amazonaws.com/uifaces/faces/twitter/yecidsm/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6143) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6212), "https://s3.amazonaws.com/uifaces/faces/twitter/aoimedia/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6293), "https://s3.amazonaws.com/uifaces/faces/twitter/jonkspr/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6374), "https://s3.amazonaws.com/uifaces/faces/twitter/mutlu82/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6386) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6459), "https://s3.amazonaws.com/uifaces/faces/twitter/mgonto/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6471) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6540), "https://s3.amazonaws.com/uifaces/faces/twitter/karalek/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6552) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6621), "https://s3.amazonaws.com/uifaces/faces/twitter/igorgarybaldi/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6698), "https://s3.amazonaws.com/uifaces/faces/twitter/alek_djuric/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6779), "https://s3.amazonaws.com/uifaces/faces/twitter/renbyrd/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6860), "https://s3.amazonaws.com/uifaces/faces/twitter/mahmoudmetwally/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6873) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6942), "https://s3.amazonaws.com/uifaces/faces/twitter/mattdetails/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(6954) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(7019), "https://s3.amazonaws.com/uifaces/faces/twitter/baumann_alex/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(7035) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(7100), "https://s3.amazonaws.com/uifaces/faces/twitter/kuldarkalvik/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(7116) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(7181), "https://s3.amazonaws.com/uifaces/faces/twitter/motionthinks/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(7258), "https://s3.amazonaws.com/uifaces/faces/twitter/urrutimeoli/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(7339), "https://s3.amazonaws.com/uifaces/faces/twitter/wesleytrankin/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(7420), "https://s3.amazonaws.com/uifaces/faces/twitter/timmillwood/128.jpg", new DateTime(2019, 6, 8, 13, 30, 1, 426, DateTimeKind.Local).AddTicks(7436) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(539), "https://picsum.photos/640/480/?image=393", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2112), "https://picsum.photos/640/480/?image=1079", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2141) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2218), "https://picsum.photos/640/480/?image=801", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2299), "https://picsum.photos/640/480/?image=951", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2315) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2376), "https://picsum.photos/640/480/?image=436", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2457), "https://picsum.photos/640/480/?image=64", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2538), "https://picsum.photos/640/480/?image=436", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2639), "https://picsum.photos/640/480/?image=243", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2656) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2720), "https://picsum.photos/640/480/?image=515", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2733) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2797), "https://picsum.photos/640/480/?image=290", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2814) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2879), "https://picsum.photos/640/480/?image=400", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2956), "https://picsum.photos/640/480/?image=839", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(3037), "https://picsum.photos/640/480/?image=926", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(3053) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(3118), "https://picsum.photos/640/480/?image=163", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(3195), "https://picsum.photos/640/480/?image=455", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(3207) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(3272), "https://picsum.photos/640/480/?image=688", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(3284) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(3349), "https://picsum.photos/640/480/?image=759", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(3430), "https://picsum.photos/640/480/?image=307", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(3442) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(3507), "https://picsum.photos/640/480/?image=488", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(3523) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(3584), "https://picsum.photos/640/480/?image=902", new DateTime(2019, 6, 8, 13, 30, 1, 439, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.InsertData(
                table: "PostReactions",
                columns: new[] { "Id", "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 3, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(3606), false, 18, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(3623), 5 },
                    { 4, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(3716), true, 6, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(3728), 5 },
                    { 5, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(3809), true, 3, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(3821), 16 },
                    { 7, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4004), true, 7, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4020), 18 },
                    { 8, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4097), true, 8, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4113), 20 },
                    { 9, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4186), false, 8, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4198), 5 },
                    { 10, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4275), false, 5, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4287), 15 },
                    { 11, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4364), false, 9, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4381), 8 },
                    { 16, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4806), true, 19, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4822), 16 },
                    { 13, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4543), false, 10, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4559), 16 },
                    { 14, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4632), true, 9, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4644), 20 },
                    { 15, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4721), false, 11, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4733), 12 },
                    { 2, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(3452), false, 7, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(3485), 13 },
                    { 17, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4904), false, 14, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4916), 15 },
                    { 18, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(5001), true, 3, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(5017), 5 },
                    { 19, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(5098), false, 3, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(5114), 10 },
                    { 20, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(5199), false, 8, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(5216), 19 },
                    { 12, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4458), false, 18, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(4470), 2 },
                    { 1, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(465), false, 2, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(1693), 1 },
                    { 6, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(3906), false, 19, new DateTime(2019, 6, 8, 13, 30, 1, 848, DateTimeKind.Local).AddTicks(3918), 13 }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 4, "Enim ea sunt eos reprehenderit maxime.", new DateTime(2019, 6, 8, 13, 30, 1, 808, DateTimeKind.Local).AddTicks(9179), 22, new DateTime(2019, 6, 8, 13, 30, 1, 809, DateTimeKind.Local).AddTicks(346) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 16, @"Exercitationem assumenda expedita eos possimus dolorem aut repellat eos.
Error voluptate molestiae et laudantium.
Explicabo ea est totam soluta esse cumque voluptatibus qui voluptatem.
Ex corrupti praesentium omnis vitae occaecati.
Dicta doloribus qui vero sit incidunt id aspernatur ipsum.", new DateTime(2019, 6, 8, 13, 30, 1, 810, DateTimeKind.Local).AddTicks(4781), 23, new DateTime(2019, 6, 8, 13, 30, 1, 810, DateTimeKind.Local).AddTicks(4826) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 11, "Non placeat asperiores qui. Quis qui aut. Tempore iste dolores.", new DateTime(2019, 6, 8, 13, 30, 1, 810, DateTimeKind.Local).AddTicks(9731), new DateTime(2019, 6, 8, 13, 30, 1, 810, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 6, @"Atque rerum consequuntur illum rem quia labore.
Vel eos qui et sunt.
Officia aspernatur magnam molestiae.
Laudantium a voluptatibus ut expedita sed et ratione.
Cupiditate unde vitae officia quos.", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(307), 31, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(323) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 10, "aperiam", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(1361), 29, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(1389) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 7, @"Quisquam nihil natus quidem dolores iusto.
Qui et aspernatur est numquam harum et est totam et.
Accusantium itaque vel eum dolor asperiores placeat.
Aut voluptatum et.
Ut neque impedit voluptatum voluptatem vel aspernatur error nihil.", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(1941), 35, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, "sed", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(2131), 40, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 19, "Voluptas praesentium similique et voluptates unde illum libero necessitatibus facilis.", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(2387), 32, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(2403) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 5, "Quos voluptas mollitia magni est quas.", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(2581), 24, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(2597) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 5, "Consequuntur ipsam est. Quo autem dolor rem quia quia perferendis et. Inventore laborum saepe. Quis dolorem provident cum a dolore voluptas et occaecati.", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(3027), 38, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(3047) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 6, "Dolorum adipisci facere repellendus incidunt quia maiores. Pariatur iure esse nisi. Voluptatum eum error quasi repellat. Aliquid et tempore quo quis dolorem quasi. Aut consectetur itaque aut optio quis soluta qui corporis.", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(3530), 26, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 21, "Qui adipisci voluptatem ratione voluptatem laborum doloribus commodi.", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(3741), 40, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(3757) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 13, "In distinctio hic ex. Et neque dignissimos odit maiores repudiandae. Quisquam ut in vitae non minima.", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(4065), 36, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(4081) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { "Aliquid eligendi aut omnis vitae in et ut. Voluptas provident aut sit. Hic ut et eius et quo. Voluptate minus ut facilis. Veniam dignissimos cum doloribus deserunt et.", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(4523), 38, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(4539) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 14, @"Et vitae ipsa velit facere.
Est consectetur asperiores natus rerum culpa autem qui in.
Illum totam rerum a similique voluptates libero sed.
Iste neque ipsum quis odit doloremque.
Quis harum officia dolores sed sint blanditiis facilis dicta.", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(5058), 28, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 16, "Corporis nulla adipisci natus ab occaecati et nihil cumque. Velit et id adipisci. Deleniti ut necessitatibus provident autem nostrum maxime. Voluptatem deleniti corporis perferendis ullam officiis eius. Qui voluptatum mollitia aliquam voluptatem.", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(5545), 40, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(5561) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 13, "molestias", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(5674), 24, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 5, "Minima omnis quaerat ab est ducimus omnis voluptatem. Sunt iste nostrum non vitae placeat molestias ex eum. Saepe deserunt dignissimos qui earum minima. Quia fugiat voluptatem id quo illum sed.", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(6116), 31, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(6132) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 12, @"Ut assumenda et et.
Voluptatem optio doloremque ipsa rerum nemo repellat quo.
Dignissimos ut magni fugiat quidem voluptatem est aut enim.
Ullam et eos quod ipsum reprehenderit rerum tempora possimus aut.
Porro reprehenderit explicabo illum sed et dolore.", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(6643), 30, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(6659) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 16, @"Sapiente quis culpa velit commodi rerum iusto voluptatum neque.
Sunt sed eum nesciunt a vero.", new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(6931), 34, new DateTime(2019, 6, 8, 13, 30, 1, 811, DateTimeKind.Local).AddTicks(6943) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 16, new DateTime(2019, 6, 8, 13, 30, 1, 498, DateTimeKind.Local).AddTicks(4064), "Lewis66@yahoo.com", "ipp+S75e/5LiuvKBM0nZrEQsP+7SMRMzqcaRN08Npeo=", "euuwrkqYzcRNJGdeN7pEtbfzLCvqO+eavPQlg+vBgT4=", new DateTime(2019, 6, 8, 13, 30, 1, 498, DateTimeKind.Local).AddTicks(5085), "Berta.Mann13" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 16, new DateTime(2019, 6, 8, 13, 30, 1, 510, DateTimeKind.Local).AddTicks(8861), "Zula.Schultz0@gmail.com", "P8ThNsvBpgNPvmH1YqSUD2/vtQRDH/Lul3MQa1elkRI=", "oI1mrCZQsTc837g5oIG3HMPEvL9DrfDpegteKB4mOas=", new DateTime(2019, 6, 8, 13, 30, 1, 510, DateTimeKind.Local).AddTicks(8946), "Emiliano_Rice44" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 1, new DateTime(2019, 6, 8, 13, 30, 1, 523, DateTimeKind.Local).AddTicks(1692), "Reagan60@yahoo.com", "0seLIYhjNnliKhex2dDOLL/USB49B2vjmm35kPNClV0=", "2VgpQTnja97w2gvln6xsIeJnhGCvbckR1fahcmznjBw=", new DateTime(2019, 6, 8, 13, 30, 1, 523, DateTimeKind.Local).AddTicks(1773), "Keely_Johnston" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 4, new DateTime(2019, 6, 8, 13, 30, 1, 535, DateTimeKind.Local).AddTicks(2230), "Keon.Lang62@yahoo.com", "6U7+IRUGC7b0o9gvk13Hmjq7fqhQrz5LUeBrI7N8KFc=", "yfVqUaYEqo8GpvMHeBTVWEvVt8tbqBlOg6RdI2UT4os=", new DateTime(2019, 6, 8, 13, 30, 1, 535, DateTimeKind.Local).AddTicks(2311), "Odell91" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 2, new DateTime(2019, 6, 8, 13, 30, 1, 547, DateTimeKind.Local).AddTicks(4604), "Itzel.Hintz@yahoo.com", "NuSFkBsHxCG6xLWi69+t4D0QQGJ6BVVhb9xbXZLdvuw=", "RhFEqCkXU6TJ/PlnhiUc1oPhH+KaEWnNBGn83ls6cpI=", new DateTime(2019, 6, 8, 13, 30, 1, 547, DateTimeKind.Local).AddTicks(4685), "Elmore_Zieme78" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 12, new DateTime(2019, 6, 8, 13, 30, 1, 563, DateTimeKind.Local).AddTicks(166), "Lonie68@hotmail.com", "9kzThCD61VguYbsRHNtsljedbZNR1l25iA5h7tnglD4=", "urBn05zOW2W/z0SRh+ROKzQA8zstGURtGXA8s6Vb2a4=", new DateTime(2019, 6, 8, 13, 30, 1, 563, DateTimeKind.Local).AddTicks(255), "Alanis58" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2019, 6, 8, 13, 30, 1, 578, DateTimeKind.Local).AddTicks(2826), "Kristin97@gmail.com", "0V7MfOMBFz35VAxpeLP/VykoHmFr7Y6TMb7KmCsI/aY=", "7sMIRbE3J8XKIl6X9jKvzdPbJKIBm2ObprWHVvqbjCg=", new DateTime(2019, 6, 8, 13, 30, 1, 578, DateTimeKind.Local).AddTicks(3337), "Mallory.Lowe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 19, new DateTime(2019, 6, 8, 13, 30, 1, 591, DateTimeKind.Local).AddTicks(1073), "Brock.Morissette45@yahoo.com", "W0C3ON2PXLVca3hpSsshp9A731PcJZ/uhs6iqIEPNO0=", "rfSm1BxD/Cz3A0fKq9SM3lViajI8Rf0JUblIsycGTHk=", new DateTime(2019, 6, 8, 13, 30, 1, 591, DateTimeKind.Local).AddTicks(1166), "Adrian47" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 19, new DateTime(2019, 6, 8, 13, 30, 1, 603, DateTimeKind.Local).AddTicks(309), "Chester.Botsford18@hotmail.com", "TD3rl13TivQ0isdJJdv3otUiNVS1qu95yZQACMf2xlw=", "D+kG+ztr9Id+AD59gxJdJygPRlt/ioTnMqMBlmFDyjE=", new DateTime(2019, 6, 8, 13, 30, 1, 603, DateTimeKind.Local).AddTicks(394), "Alysha_Kovacek" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 1, new DateTime(2019, 6, 8, 13, 30, 1, 617, DateTimeKind.Local).AddTicks(9451), "Marcelina62@yahoo.com", "aLjZF/bDcOOeW7qCP9dwuSPumeOm9QRufFkUKft46+4=", "bh5Ft5t/KbW9P4fmQXyGpy+XgKou4wo7+Rdd1ySJm8Y=", new DateTime(2019, 6, 8, 13, 30, 1, 617, DateTimeKind.Local).AddTicks(9552), "Rupert_Kassulke55" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 639, DateTimeKind.Local).AddTicks(2043), "Shaylee79@yahoo.com", "Rh0T1eDmyKZIDhDBfPV7+xzjf1K+T84PENeigQVqr+E=", "bYVeC1RbOLLbVVmDf1eTE1dAGCKYfgEgYbNWtgYNIyk=", new DateTime(2019, 6, 8, 13, 30, 1, 639, DateTimeKind.Local).AddTicks(2132), "Gwendolyn_Boehm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 4, new DateTime(2019, 6, 8, 13, 30, 1, 661, DateTimeKind.Local).AddTicks(877), "Mauricio.Von33@yahoo.com", "UTni2loimGZ5Kti93HaEZ+fciZCwfO/ZaPOc44RxhhM=", "cYSMaR0B14+YVoFvlt8tjpPoZY2z5K5jIFb2xsHfxZs=", new DateTime(2019, 6, 8, 13, 30, 1, 661, DateTimeKind.Local).AddTicks(966), "Coleman_Bosco95" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 7, new DateTime(2019, 6, 8, 13, 30, 1, 673, DateTimeKind.Local).AddTicks(2489), "Elton.Farrell22@hotmail.com", "DSLPWWQIc4TRCSD6QevyvmOV2Q8UikaYj+CawmvEYhM=", "Nd3AGdFKVWNX6lV8EepGfNXRRTrIbZt+crUIxwN7K4A=", new DateTime(2019, 6, 8, 13, 30, 1, 673, DateTimeKind.Local).AddTicks(2582), "Delores_Hauck92" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 7, new DateTime(2019, 6, 8, 13, 30, 1, 685, DateTimeKind.Local).AddTicks(5677), "Sabryna13@hotmail.com", "2I1TP1TVsZiysC0zeVLdGzmL6bsTG5Yro1ZMoZPOVZs=", "2ttqWS2Z+EZN+C1+MQpRFtwsg1kh/bqEJOhp5GaQdo0=", new DateTime(2019, 6, 8, 13, 30, 1, 685, DateTimeKind.Local).AddTicks(5778), "Lucie32" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 17, new DateTime(2019, 6, 8, 13, 30, 1, 702, DateTimeKind.Local).AddTicks(7746), "Ardith.Cummings95@yahoo.com", "XKm4g0rS/kMzXDlq1A0xd0Mj1UTKz78QZqEIjGiVzaI=", "joVmnahae87VaRCkiCZANdQn93d2cMmII5sssUek7AQ=", new DateTime(2019, 6, 8, 13, 30, 1, 702, DateTimeKind.Local).AddTicks(7844), "Benton99" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2019, 6, 8, 13, 30, 1, 724, DateTimeKind.Local).AddTicks(7786), "Wilfrid54@yahoo.com", "dymXvZziyvE784wDCRRuv+Kazm4duf2yUAZQJG9MFzw=", "6iWfzQsuyR5S7/Xx02k+yJV5y6UWvnNU4rUmZYTba58=", new DateTime(2019, 6, 8, 13, 30, 1, 724, DateTimeKind.Local).AddTicks(7875), "Shaylee.King" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 4, new DateTime(2019, 6, 8, 13, 30, 1, 741, DateTimeKind.Local).AddTicks(6309), "Harold.Rowe71@yahoo.com", "LoU3WAtUBJTUjad+UJqki5rZ6n/M9omgb/3+yVk7vMw=", "n/uUFtMkyUefMnQNz/j6Vaqzr/osn7pBREHzWM8lIU8=", new DateTime(2019, 6, 8, 13, 30, 1, 741, DateTimeKind.Local).AddTicks(6406), "Cali.Waters" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 3, new DateTime(2019, 6, 8, 13, 30, 1, 753, DateTimeKind.Local).AddTicks(8333), "Samanta_OReilly95@yahoo.com", "+YA8dDK1ZoLFTvfpnVQGzmhKXHRaAgN/fQjmZMVMGcM=", "Bhn9S4MMVApZjnGJUamRVV4ikTzCgdc/KBbTMldMsjY=", new DateTime(2019, 6, 8, 13, 30, 1, 753, DateTimeKind.Local).AddTicks(8426), "Baylee_Sipes42" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 765, DateTimeKind.Local).AddTicks(8563), "Rex64@hotmail.com", "JOICOM6OozRPh4VLEbxS/iJMsI1HhHyOdDtuG4tau78=", "EdoXXUo+awEKlbwKaH/IFKIzz1Ybyl69YYeYJACQ/nM=", new DateTime(2019, 6, 8, 13, 30, 1, 765, DateTimeKind.Local).AddTicks(8648), "Sharon32" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 2, new DateTime(2019, 6, 8, 13, 30, 1, 779, DateTimeKind.Local).AddTicks(1504), "Brice_Abshire72@gmail.com", "D+HiHDuS3LIsqdZUuSEQeZ0VSpvsWiTYTKiW1JwGMPU=", "unJ1mBlcdh5pmmYITwm9s49RsQknqWgoUYsqdrOvjbI=", new DateTime(2019, 6, 8, 13, 30, 1, 779, DateTimeKind.Local).AddTicks(1590), "Kayla46" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Password", "Salt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 30, 1, 791, DateTimeKind.Local).AddTicks(1782), "i2TJ0z00NYlgYE1RckEz65RuduHNOi6XLzkY/zjls3M=", "OfXWhBQuNh3ZiHzV/LYq5X7zvFdI56jXiAJ/cQcbvJM=", new DateTime(2019, 6, 8, 13, 30, 1, 791, DateTimeKind.Local).AddTicks(1782) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_CommentReactions_CommentId_UserId",
                table: "CommentReactions");

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 16, new DateTime(2019, 6, 8, 13, 24, 10, 953, DateTimeKind.Local).AddTicks(7307), true, new DateTime(2019, 6, 8, 13, 24, 10, 953, DateTimeKind.Local).AddTicks(8252), 6 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 1, new DateTime(2019, 6, 8, 13, 24, 10, 953, DateTimeKind.Local).AddTicks(9460), true, new DateTime(2019, 6, 8, 13, 24, 10, 953, DateTimeKind.Local).AddTicks(9480), 7 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 11, new DateTime(2019, 6, 8, 13, 24, 10, 953, DateTimeKind.Local).AddTicks(9565), new DateTime(2019, 6, 8, 13, 24, 10, 953, DateTimeKind.Local).AddTicks(9573), 1 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 5, new DateTime(2019, 6, 8, 13, 24, 10, 953, DateTimeKind.Local).AddTicks(9622), false, new DateTime(2019, 6, 8, 13, 24, 10, 953, DateTimeKind.Local).AddTicks(9630), 17 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 20, new DateTime(2019, 6, 8, 13, 24, 10, 953, DateTimeKind.Local).AddTicks(9675), false, new DateTime(2019, 6, 8, 13, 24, 10, 953, DateTimeKind.Local).AddTicks(9683), 7 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 12, new DateTime(2019, 6, 8, 13, 24, 10, 953, DateTimeKind.Local).AddTicks(9727), new DateTime(2019, 6, 8, 13, 24, 10, 953, DateTimeKind.Local).AddTicks(9735), 2 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 19, new DateTime(2019, 6, 8, 13, 24, 10, 953, DateTimeKind.Local).AddTicks(9776), true, new DateTime(2019, 6, 8, 13, 24, 10, 953, DateTimeKind.Local).AddTicks(9784), 2 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 16, new DateTime(2019, 6, 8, 13, 24, 10, 953, DateTimeKind.Local).AddTicks(9829), new DateTime(2019, 6, 8, 13, 24, 10, 953, DateTimeKind.Local).AddTicks(9837), 20 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 18, new DateTime(2019, 6, 8, 13, 24, 10, 953, DateTimeKind.Local).AddTicks(9881), true, new DateTime(2019, 6, 8, 13, 24, 10, 953, DateTimeKind.Local).AddTicks(9885), 13 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 19, new DateTime(2019, 6, 8, 13, 24, 10, 953, DateTimeKind.Local).AddTicks(9930), new DateTime(2019, 6, 8, 13, 24, 10, 953, DateTimeKind.Local).AddTicks(9934), 2 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 17, new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(133), true, new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(145), 18 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 11, new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(202), false, new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(206), 15 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 20, new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(250), true, new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(258), 9 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(303), new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(311), 17 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 8, new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(352), false, new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(360), 19 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 1, new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(404), true, new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(412), 9 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 5, new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(453), false, new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(461), 14 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(506), true, new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(514), 14 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 7, new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(554), new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(562), 1 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 15, new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(607), false, new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(615), 21 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 4, "Non corrupti sint excepturi consequatur ut debitis ut.", new DateTime(2019, 6, 8, 13, 24, 10, 924, DateTimeKind.Local).AddTicks(9115), 18, new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 17, "Eum optio sunt architecto.", new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(1300), 18, new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(1324) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 18, "Dolor culpa ut tempora.", new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(1466), 1, new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(1474) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 6, "Aut nam nulla quaerat.", new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(1572), 8, new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 7, "Voluptatem et minima sed id et.", new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(1673), 19, new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(1681) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 20, "Perferendis magnam magnam quia exercitationem in eveniet.", new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(1807), 12, new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(1815) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 8, "Odit est eum ut corporis facilis accusamus.", new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(1908), 19, new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 7, "Aperiam quo et molestias omnis ea harum.", new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(2014), 11, new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(2022) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 8, "Aut vero voluptatem inventore.", new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(2099), 20, new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(2107) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 6, "Molestiae et deleniti voluptas ut tempore quidem.", new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(2200), 16, new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 7, "Porro reiciendis necessitatibus minus excepturi eum nemo corrupti.", new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(2301), 7, new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(2309) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 9, "Ea recusandae assumenda id ea in mollitia magnam.", new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(2419), 7, new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(2427) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 11, "Voluptas ab earum.", new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(2504), 9, new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(2512) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 10, "Magni eaque ut tempora ut est repudiandae ipsam est.", new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(2609), 10, new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(2618) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 20, "Tenetur similique aperiam harum pariatur similique.", new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(2699), 15, new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(2711) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 8, "Et enim ipsa doloremque.", new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(2780), 7, new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 2, "Et voluptas temporibus voluptatem recusandae totam ea voluptatem.", new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(2881), 11, new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(2889) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 17, "Non vero quis possimus hic aut.", new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(2990), 10, new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(2999) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 5, "Reiciendis optio velit autem natus id cum harum voluptas.", new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(3096), 4, new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(3108) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 11, "Velit quia nam aut distinctio voluptatum ut.", new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(3193), 5, new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 589, DateTimeKind.Local).AddTicks(3877), "https://s3.amazonaws.com/uifaces/faces/twitter/jnmnrd/128.jpg", new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(6760), "https://s3.amazonaws.com/uifaces/faces/twitter/ripplemdk/128.jpg", new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(6841), "https://s3.amazonaws.com/uifaces/faces/twitter/depaulawagner/128.jpg", new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(6889), "https://s3.amazonaws.com/uifaces/faces/twitter/romanbulah/128.jpg", new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(6897) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(6934), "https://s3.amazonaws.com/uifaces/faces/twitter/kushsolitary/128.jpg", new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(6942) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(6983), "https://s3.amazonaws.com/uifaces/faces/twitter/elliotlewis/128.jpg", new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(6991) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(7027), "https://s3.amazonaws.com/uifaces/faces/twitter/akmur/128.jpg", new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(7035) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(7072), "https://s3.amazonaws.com/uifaces/faces/twitter/maxlinderman/128.jpg", new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(7120), "https://s3.amazonaws.com/uifaces/faces/twitter/conspirator/128.jpg", new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(7128) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(7165), "https://s3.amazonaws.com/uifaces/faces/twitter/thewillbeard/128.jpg", new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(7210), "https://s3.amazonaws.com/uifaces/faces/twitter/gipsy_raf/128.jpg", new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(7254), "https://s3.amazonaws.com/uifaces/faces/twitter/batsirai/128.jpg", new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(7331), "https://s3.amazonaws.com/uifaces/faces/twitter/rtgibbons/128.jpg", new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(7376), "https://s3.amazonaws.com/uifaces/faces/twitter/dmackerman/128.jpg", new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(7384) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(7424), "https://s3.amazonaws.com/uifaces/faces/twitter/salvafc/128.jpg", new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(7432) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(7469), "https://s3.amazonaws.com/uifaces/faces/twitter/marshallchen_/128.jpg", new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(7518), "https://s3.amazonaws.com/uifaces/faces/twitter/hanna_smi/128.jpg", new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(7526) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(7562), "https://s3.amazonaws.com/uifaces/faces/twitter/arindam_/128.jpg", new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(7611), "https://s3.amazonaws.com/uifaces/faces/twitter/franciscoamk/128.jpg", new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(7619) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(7655), "https://s3.amazonaws.com/uifaces/faces/twitter/codysanfilippo/128.jpg", new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(3720), "https://picsum.photos/640/480/?image=382", new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(4737) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(5171), "https://picsum.photos/640/480/?image=100", new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(5187) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(5232), "https://picsum.photos/640/480/?image=728", new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(5240) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(5503), "https://picsum.photos/640/480/?image=445", new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(5572), "https://picsum.photos/640/480/?image=768", new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(5613), "https://picsum.photos/640/480/?image=436", new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(5657), "https://picsum.photos/640/480/?image=580", new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(5665) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(5702), "https://picsum.photos/640/480/?image=92", new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(5742), "https://picsum.photos/640/480/?image=389", new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(5751) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(5787), "https://picsum.photos/640/480/?image=247", new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(5795) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(5828), "https://picsum.photos/640/480/?image=1022", new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(5836) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(5872), "https://picsum.photos/640/480/?image=1055", new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(5876) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(5913), "https://picsum.photos/640/480/?image=437", new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(5953), "https://picsum.photos/640/480/?image=195", new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(5961) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(5998), "https://picsum.photos/640/480/?image=23", new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(6140), "https://picsum.photos/640/480/?image=315", new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(6152) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(6205), "https://picsum.photos/640/480/?image=1048", new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(6249), "https://picsum.photos/640/480/?image=703", new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(6290), "https://picsum.photos/640/480/?image=617", new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(6298) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(6334), "https://picsum.photos/640/480/?image=412", new DateTime(2019, 6, 8, 13, 24, 10, 600, DateTimeKind.Local).AddTicks(6342) });

            migrationBuilder.InsertData(
                table: "PostReactions",
                columns: new[] { "Id", "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 3, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(4215), false, 7, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(4223), 16 },
                    { 4, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(4272), false, 18, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(4280), 6 },
                    { 5, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(4321), false, 20, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(4325), 16 },
                    { 7, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(4418), true, 15, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(4426), 17 },
                    { 8, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(4467), true, 7, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(4475), 18 },
                    { 9, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(4515), false, 13, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(4523), 17 },
                    { 10, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(4564), false, 6, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(4572), 20 },
                    { 11, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(4613), false, 20, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(4617), 5 },
                    { 16, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(5026), false, 10, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(5034), 19 },
                    { 13, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(4706), false, 17, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(4714), 5 },
                    { 14, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(4750), false, 18, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(4758), 17 },
                    { 15, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(4969), true, 19, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(4977), 7 },
                    { 2, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(4138), true, 18, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(4158), 16 },
                    { 17, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(5075), false, 5, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(5083), 4 },
                    { 18, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(5123), true, 14, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(5131), 8 },
                    { 19, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(5168), true, 15, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(5176), 6 },
                    { 20, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(5217), true, 19, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(5225), 9 },
                    { 12, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(4657), false, 3, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(4665), 5 },
                    { 1, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(1912), false, 7, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(2857), 12 },
                    { 6, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(4365), false, 10, new DateTime(2019, 6, 8, 13, 24, 10, 940, DateTimeKind.Local).AddTicks(4373), 9 }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 17, @"Laboriosam nihil dignissimos excepturi quas.
Dolore qui magnam accusamus.
Recusandae molestiae vitae quae.
Enim ut atque.", new DateTime(2019, 6, 8, 13, 24, 10, 909, DateTimeKind.Local).AddTicks(5003), 33, new DateTime(2019, 6, 8, 13, 24, 10, 909, DateTimeKind.Local).AddTicks(6195) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 2, "et", new DateTime(2019, 6, 8, 13, 24, 10, 909, DateTimeKind.Local).AddTicks(8392), 31, new DateTime(2019, 6, 8, 13, 24, 10, 909, DateTimeKind.Local).AddTicks(8424) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 19, "voluptatem", new DateTime(2019, 6, 8, 13, 24, 10, 909, DateTimeKind.Local).AddTicks(8680), new DateTime(2019, 6, 8, 13, 24, 10, 909, DateTimeKind.Local).AddTicks(8696) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 11, "Aut fuga nobis architecto ab accusantium consectetur qui. Necessitatibus eos assumenda est distinctio assumenda excepturi velit quia itaque. Ab repudiandae occaecati. Fuga itaque ducimus voluptatum ipsum. Impedit totam voluptatibus sint sapiente ullam qui. Maiores quis ipsa laboriosam rerum necessitatibus consectetur aperiam vero ea.", new DateTime(2019, 6, 8, 13, 24, 10, 910, DateTimeKind.Local).AddTicks(3529), 26, new DateTime(2019, 6, 8, 13, 24, 10, 910, DateTimeKind.Local).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 16, "Nulla temporibus nobis inventore aut in qui fugit.", new DateTime(2019, 6, 8, 13, 24, 10, 910, DateTimeKind.Local).AddTicks(6350), 32, new DateTime(2019, 6, 8, 13, 24, 10, 910, DateTimeKind.Local).AddTicks(6383) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, "Qui repellendus dolores optio. Fugit tempora modi et illo impedit. Et aspernatur officia vitae quae. Distinctio eos ipsa dolorum.", new DateTime(2019, 6, 8, 13, 24, 10, 910, DateTimeKind.Local).AddTicks(6820), 24, new DateTime(2019, 6, 8, 13, 24, 10, 910, DateTimeKind.Local).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 3, "Occaecati officiis impedit voluptas commodi ut nihil quibusdam dolore quisquam. Temporibus qui tempora ducimus adipisci minus reiciendis dolor. Ullam eos doloremque provident quas ipsam.", new DateTime(2019, 6, 8, 13, 24, 10, 910, DateTimeKind.Local).AddTicks(7453), 25, new DateTime(2019, 6, 8, 13, 24, 10, 910, DateTimeKind.Local).AddTicks(7481) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 15, "Autem ad fugit nihil ut. Qui nisi consequatur molestiae corporis nisi commodi nisi nihil voluptatem. Deserunt molestiae praesentium at quia quisquam optio distinctio nulla quia. Ab eaque error voluptatem expedita esse voluptates sint minima. Aspernatur magnam consequatur harum omnis unde repellat.", new DateTime(2019, 6, 8, 13, 24, 10, 910, DateTimeKind.Local).AddTicks(8235), 31, new DateTime(2019, 6, 8, 13, 24, 10, 910, DateTimeKind.Local).AddTicks(8260) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 7, "beatae", new DateTime(2019, 6, 8, 13, 24, 10, 910, DateTimeKind.Local).AddTicks(8385), 22, new DateTime(2019, 6, 8, 13, 24, 10, 910, DateTimeKind.Local).AddTicks(8401) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 20, @"Qui tempore omnis quam.
Quas assumenda et.
Ut ea minima nobis hic.", new DateTime(2019, 6, 8, 13, 24, 10, 910, DateTimeKind.Local).AddTicks(8924), 29, new DateTime(2019, 6, 8, 13, 24, 10, 910, DateTimeKind.Local).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 16, "Quia qui eius ut ipsum optio. Quia maiores maxime repellat. Sit cum non sapiente ut sapiente eos deleniti. Atque aut laboriosam consequatur consectetur quisquam quo.", new DateTime(2019, 6, 8, 13, 24, 10, 910, DateTimeKind.Local).AddTicks(9403), 35, new DateTime(2019, 6, 8, 13, 24, 10, 910, DateTimeKind.Local).AddTicks(9427) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 2, "et", new DateTime(2019, 6, 8, 13, 24, 10, 910, DateTimeKind.Local).AddTicks(9549), 39, new DateTime(2019, 6, 8, 13, 24, 10, 910, DateTimeKind.Local).AddTicks(9565) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 7, "cum", new DateTime(2019, 6, 8, 13, 24, 10, 910, DateTimeKind.Local).AddTicks(9670), 25, new DateTime(2019, 6, 8, 13, 24, 10, 910, DateTimeKind.Local).AddTicks(9687) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { "Ut voluptas dolor nesciunt exercitationem dolore nisi id.", new DateTime(2019, 6, 8, 13, 24, 10, 911, DateTimeKind.Local).AddTicks(205), 24, new DateTime(2019, 6, 8, 13, 24, 10, 911, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 20, "earum", new DateTime(2019, 6, 8, 13, 24, 10, 911, DateTimeKind.Local).AddTicks(359), 23, new DateTime(2019, 6, 8, 13, 24, 10, 911, DateTimeKind.Local).AddTicks(376) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 17, "Aut ut voluptatibus reiciendis nemo. Tempora sunt non temporibus sapiente quas. Minus voluptates qui qui in enim cumque earum ipsa. Pariatur fugit cum minus error tempora rerum. Sequi deleniti voluptas.", new DateTime(2019, 6, 8, 13, 24, 10, 911, DateTimeKind.Local).AddTicks(992), 28, new DateTime(2019, 6, 8, 13, 24, 10, 911, DateTimeKind.Local).AddTicks(1016) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 6, "Mollitia accusamus iste qui consequatur praesentium vel aspernatur.", new DateTime(2019, 6, 8, 13, 24, 10, 911, DateTimeKind.Local).AddTicks(1251), 27, new DateTime(2019, 6, 8, 13, 24, 10, 911, DateTimeKind.Local).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 21, "Voluptatibus voluptas et doloribus voluptate.", new DateTime(2019, 6, 8, 13, 24, 10, 911, DateTimeKind.Local).AddTicks(1438), 37, new DateTime(2019, 6, 8, 13, 24, 10, 911, DateTimeKind.Local).AddTicks(1454) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 16, "eos", new DateTime(2019, 6, 8, 13, 24, 10, 911, DateTimeKind.Local).AddTicks(1563), 33, new DateTime(2019, 6, 8, 13, 24, 10, 911, DateTimeKind.Local).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 21, @"Omnis consequatur accusantium cupiditate vel sed sit in voluptatibus in.
Ea cum aspernatur totam.
Quis deleniti ad.", new DateTime(2019, 6, 8, 13, 24, 10, 911, DateTimeKind.Local).AddTicks(2070), 38, new DateTime(2019, 6, 8, 13, 24, 10, 911, DateTimeKind.Local).AddTicks(2095) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 13, new DateTime(2019, 6, 8, 13, 24, 10, 649, DateTimeKind.Local).AddTicks(8537), "Imelda_Mitchell@hotmail.com", "wyS8r7yMuR/yYkZpf5BJOxg5V9qqg4UGqbMM+Pgag3E=", "d3lRpJNDHy3y6QlutEp0jv53B8TOANIq/vlG5QN2bfY=", new DateTime(2019, 6, 8, 13, 24, 10, 649, DateTimeKind.Local).AddTicks(9643), "Reuben.Christiansen89" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 15, new DateTime(2019, 6, 8, 13, 24, 10, 662, DateTimeKind.Local).AddTicks(3481), "Nathanial_Fadel@yahoo.com", "UTyh4GQu9OjyCxUQIJgRn7uNifHqj18ddaAyieFubzs=", "p8WXhYEGnfjAgjxwoqm4+LWluwKSbMHVqH804hivgRc=", new DateTime(2019, 6, 8, 13, 24, 10, 662, DateTimeKind.Local).AddTicks(3537), "Kaya_Abshire" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 17, new DateTime(2019, 6, 8, 13, 24, 10, 675, DateTimeKind.Local).AddTicks(2774), "Amy51@yahoo.com", "0XAVOmsGos6NYeYfA/aLk5GXkTC/lGugwyDmc3GVuxk=", "9QZwjNGZmsgRslXzE551bMUPlyApp/Vw4iyBUH1W6tY=", new DateTime(2019, 6, 8, 13, 24, 10, 675, DateTimeKind.Local).AddTicks(2908), "Vanessa6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 15, new DateTime(2019, 6, 8, 13, 24, 10, 688, DateTimeKind.Local).AddTicks(2186), "Chauncey7@yahoo.com", "P2O/2CzM5A657L1OGFHD+VDHCzJ9cCBYN2tl7RdbwRs=", "fufyUMFjYHZLYY+aHzcmkG97Z5t3Dc9TAQYSSk3dlDg=", new DateTime(2019, 6, 8, 13, 24, 10, 688, DateTimeKind.Local).AddTicks(2271), "Deja46" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 19, new DateTime(2019, 6, 8, 13, 24, 10, 700, DateTimeKind.Local).AddTicks(1186), "Eliseo30@gmail.com", "JDsGalAoSUg9xBSvO2KtbAEI620GjZr7RoHrSRopwjI=", "kVzmhMtXPNV3V46lUi4CgKUgMb/bP87dNmZ25VeUehI=", new DateTime(2019, 6, 8, 13, 24, 10, 700, DateTimeKind.Local).AddTicks(1222), "Emie.Keeling" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 4, new DateTime(2019, 6, 8, 13, 24, 10, 711, DateTimeKind.Local).AddTicks(9628), "Noemi56@hotmail.com", "WHmpfsxTZ4a3ki+FfZYEoXYhXzJ419KDH4vpbvHlgS4=", "4TfDGaYCE5ugQdQDVp6wr4xZjNZONPLhY1J9JcjANok=", new DateTime(2019, 6, 8, 13, 24, 10, 711, DateTimeKind.Local).AddTicks(9713), "Sheldon_Leffler10" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 12, new DateTime(2019, 6, 8, 13, 24, 10, 723, DateTimeKind.Local).AddTicks(8020), "Kendall2@hotmail.com", "VYXxf4nvupXQS6Zz1Q2N76V6q3nr8M1qvNI23DelvsQ=", "ftAaNGT6QbRtbPDvY8AOVnYAxk26i0U9mjoM2JOFZPc=", new DateTime(2019, 6, 8, 13, 24, 10, 723, DateTimeKind.Local).AddTicks(8065), "Jeffrey.Cole18" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 11, new DateTime(2019, 6, 8, 13, 24, 10, 735, DateTimeKind.Local).AddTicks(5554), "Elody.McGlynn@gmail.com", "89BGXQqv8APjIrKdd1LmcgWMnK2GEuf8vFiFuodfmLU=", "d9K+61rDS4X4iKI2KacIHZjSeeToefvetYuY0pmRocw=", new DateTime(2019, 6, 8, 13, 24, 10, 735, DateTimeKind.Local).AddTicks(5582), "Casimir.Kuvalis66" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 1, new DateTime(2019, 6, 8, 13, 24, 10, 747, DateTimeKind.Local).AddTicks(3135), "Annabelle.Pfannerstill70@hotmail.com", "LQ1QG1OPoMELqJgtjbMWJ4jLHwz6X3C4GIVsU74ihy0=", "Dtb/ilr4hTxeksCopdumegbCs1p3RkOQ3enWUr5gVwQ=", new DateTime(2019, 6, 8, 13, 24, 10, 747, DateTimeKind.Local).AddTicks(3163), "Cecil31" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 19, new DateTime(2019, 6, 8, 13, 24, 10, 759, DateTimeKind.Local).AddTicks(3778), "Tomasa83@hotmail.com", "4aUN8reXCO7XnIgBLe9bulWG9Aytr0dyz5NB0KeaMlw=", "rXTAahrjJYyxxGPoID3uZv+T0+974g7uOY1yAi00YDc=", new DateTime(2019, 6, 8, 13, 24, 10, 759, DateTimeKind.Local).AddTicks(3802), "Claire.Schimmel89" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 771, DateTimeKind.Local).AddTicks(3075), "Marcelo_Kutch57@gmail.com", "aPkSwOPUqajY5apaCrNq9PpIU8WgqL40Axggd6iK99E=", "FQ573nSXcqf75rmGCG4x0dGJvbhDZwKLPRxp6fQ6IzI=", new DateTime(2019, 6, 8, 13, 24, 10, 771, DateTimeKind.Local).AddTicks(3124), "Wyatt.Wilkinson82" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 19, new DateTime(2019, 6, 8, 13, 24, 10, 783, DateTimeKind.Local).AddTicks(385), "Twila_VonRueden@gmail.com", "9NtWMl54l2wZstG4AyDSiAJChnhDBTX032xl0uapvY0=", "sNSoVnVP2Yp1OhZtO9I2p9+12i1AswsoGjLRhGyzhho=", new DateTime(2019, 6, 8, 13, 24, 10, 783, DateTimeKind.Local).AddTicks(405), "Carroll78" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 2, new DateTime(2019, 6, 8, 13, 24, 10, 794, DateTimeKind.Local).AddTicks(7006), "Camylle.Kuhic19@hotmail.com", "PPtN9ynCvm6BmzyJmuEQ7MjPQNja5ahy+PbJz6IJRxQ=", "76xYe45mt5Q85hwABGNl4hF+bkPfnuhgndSyxVRjsfM=", new DateTime(2019, 6, 8, 13, 24, 10, 794, DateTimeKind.Local).AddTicks(7026), "Kip_King21" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2019, 6, 8, 13, 24, 10, 806, DateTimeKind.Local).AddTicks(4539), "Zelda34@hotmail.com", "4S5rujwzG/q2ADzkwQ8izczTxibwgZmZ6/FY5Xd8uX4=", "cgL2Ma/TiU44ljZ75rx5aAWEYz8yZcsNjso2aToyWnU=", new DateTime(2019, 6, 8, 13, 24, 10, 806, DateTimeKind.Local).AddTicks(4572), "Karlee.Wyman" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 3, new DateTime(2019, 6, 8, 13, 24, 10, 818, DateTimeKind.Local).AddTicks(2178), "Carey5@gmail.com", "L2Z2SFAz1AyehYLHIH8vxPhqsroqNXEW9QVdAz7r2yU=", "F6WiaxRQVU3kSKfLyE4BfORG6+8xUoM14C7xmUpfPxk=", new DateTime(2019, 6, 8, 13, 24, 10, 818, DateTimeKind.Local).AddTicks(2207), "Jermaine_Abshire75" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 20, new DateTime(2019, 6, 8, 13, 24, 10, 829, DateTimeKind.Local).AddTicks(9690), "Theodore_Hansen@yahoo.com", "/k18UDf/tV+SVuGXwWZ9YgRRt3T+6ADCZmwdkOyhjiQ=", "MIKcgdu0Mi8ubIscY6n2DTafZ16fK3Ap++BRTM2JY6I=", new DateTime(2019, 6, 8, 13, 24, 10, 829, DateTimeKind.Local).AddTicks(9715), "Lucas_Homenick" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 7, new DateTime(2019, 6, 8, 13, 24, 10, 841, DateTimeKind.Local).AddTicks(7017), "Betty.Sipes@yahoo.com", "VZ3S8wR2Um0qYP4g95PjVPPfUgdD9pe3eNagQlJi5IA=", "VWq9YflxtYqgePBtAWkMqx0TluE024suOAGe8VvmjFY=", new DateTime(2019, 6, 8, 13, 24, 10, 841, DateTimeKind.Local).AddTicks(7049), "Amos_Barrows" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 8, new DateTime(2019, 6, 8, 13, 24, 10, 854, DateTimeKind.Local).AddTicks(692), "Remington.Kshlerin@yahoo.com", "ymLk+n3xMfUG+KCKCh9ZrrMMmNKqvjs50hneHGaMUNI=", "78EYRe71iMiTNOxdElqZ0s4HFzmN7YbjhfoSuTgwS/E=", new DateTime(2019, 6, 8, 13, 24, 10, 854, DateTimeKind.Local).AddTicks(716), "Marta48" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 865, DateTimeKind.Local).AddTicks(8785), "Cathy.Farrell70@hotmail.com", "39WyNceHUmTJcxJiDCQxID/u/Nsu6lE09HbMlb3bc1Q=", "H95PjqcgDx705qBP4ZYroF6ow8eiVLOvBlGzytba7Ro=", new DateTime(2019, 6, 8, 13, 24, 10, 865, DateTimeKind.Local).AddTicks(8809), "Esteban_Lynch" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 7, new DateTime(2019, 6, 8, 13, 24, 10, 879, DateTimeKind.Local).AddTicks(8006), "Dina.Kuhn49@gmail.com", "URkbHB7R11wL0/JYYDTkum0+Bd4zlwZCKBpy5fZPrf8=", "uG4w3oyzQsKt1GUvHg1yAx5ZHhSE1pBPFHGGo5Yr7yU=", new DateTime(2019, 6, 8, 13, 24, 10, 879, DateTimeKind.Local).AddTicks(8095), "Mitchell.Morar3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Password", "Salt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 891, DateTimeKind.Local).AddTicks(4960), "QVKpHEyoJLWG3jel9WXMt7oZZAwAByiIyMDoo9hnDGQ=", "6GRVMRd5wxVCxlerTQTqzThL21t7W1A20dMYl+ebfNE=", new DateTime(2019, 6, 8, 13, 24, 10, 891, DateTimeKind.Local).AddTicks(4960) });

            migrationBuilder.CreateIndex(
                name: "IX_CommentReactions_CommentId",
                table: "CommentReactions",
                column: "CommentId");
        }
    }
}
