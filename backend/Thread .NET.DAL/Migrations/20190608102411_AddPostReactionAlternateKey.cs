using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Thread_.NET.DAL.Migrations
{
    public partial class AddPostReactionAlternateKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PostReactions_PostId",
                table: "PostReactions");

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
                name: "AK_PostReactions_PostId_UserId",
                table: "PostReactions",
                columns: new[] { "PostId", "UserId" });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 16, new DateTime(2019, 6, 8, 13, 24, 10, 953, DateTimeKind.Local).AddTicks(7307), new DateTime(2019, 6, 8, 13, 24, 10, 953, DateTimeKind.Local).AddTicks(8252), 6 });

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
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 11, new DateTime(2019, 6, 8, 13, 24, 10, 953, DateTimeKind.Local).AddTicks(9565), false, new DateTime(2019, 6, 8, 13, 24, 10, 953, DateTimeKind.Local).AddTicks(9573), 1 });

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
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 16, new DateTime(2019, 6, 8, 13, 24, 10, 953, DateTimeKind.Local).AddTicks(9829), true, new DateTime(2019, 6, 8, 13, 24, 10, 953, DateTimeKind.Local).AddTicks(9837), 20 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 18, new DateTime(2019, 6, 8, 13, 24, 10, 953, DateTimeKind.Local).AddTicks(9881), new DateTime(2019, 6, 8, 13, 24, 10, 953, DateTimeKind.Local).AddTicks(9885), 13 });

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
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 17, new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(133), new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(145), 18 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 11, new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(202), new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(206), 15 });

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
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 18, new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(303), new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(311), 17 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 8, new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(352), new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(360), 19 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 1, new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(404), new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(412), 9 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 5, new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(453), new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(461), 14 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 7, new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(506), true, new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(514), 14 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 7, new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(554), false, new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(562), 1 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 15, new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(607), new DateTime(2019, 6, 8, 13, 24, 10, 954, DateTimeKind.Local).AddTicks(615), 21 });

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
                columns: new[] { "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { "Eum optio sunt architecto.", new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(1300), 18, new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(1324) });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 7, "Aperiam quo et molestias omnis ea harum.", new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(2014), new DateTime(2019, 6, 8, 13, 24, 10, 925, DateTimeKind.Local).AddTicks(2022) });

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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(7331), new DateTime(2019, 6, 8, 13, 24, 10, 590, DateTimeKind.Local).AddTicks(7339) });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 19, "voluptatem", new DateTime(2019, 6, 8, 13, 24, 10, 909, DateTimeKind.Local).AddTicks(8680), 34, new DateTime(2019, 6, 8, 13, 24, 10, 909, DateTimeKind.Local).AddTicks(8696) });

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
                columns: new[] { "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { "Qui repellendus dolores optio. Fugit tempora modi et illo impedit. Et aspernatur officia vitae quae. Distinctio eos ipsa dolorum.", new DateTime(2019, 6, 8, 13, 24, 10, 910, DateTimeKind.Local).AddTicks(6820), 24, new DateTime(2019, 6, 8, 13, 24, 10, 910, DateTimeKind.Local).AddTicks(6837) });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 2, "et", new DateTime(2019, 6, 8, 13, 24, 10, 910, DateTimeKind.Local).AddTicks(9549), new DateTime(2019, 6, 8, 13, 24, 10, 910, DateTimeKind.Local).AddTicks(9565) });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 21, "Ut voluptas dolor nesciunt exercitationem dolore nisi id.", new DateTime(2019, 6, 8, 13, 24, 10, 911, DateTimeKind.Local).AddTicks(205), 24, new DateTime(2019, 6, 8, 13, 24, 10, 911, DateTimeKind.Local).AddTicks(230) });

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
                columns: new[] { "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2019, 6, 8, 13, 24, 10, 662, DateTimeKind.Local).AddTicks(3481), "Nathanial_Fadel@yahoo.com", "UTyh4GQu9OjyCxUQIJgRn7uNifHqj18ddaAyieFubzs=", "p8WXhYEGnfjAgjxwoqm4+LWluwKSbMHVqH804hivgRc=", new DateTime(2019, 6, 8, 13, 24, 10, 662, DateTimeKind.Local).AddTicks(3537), "Kaya_Abshire" });

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
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2019, 6, 8, 13, 24, 10, 865, DateTimeKind.Local).AddTicks(8785), "Cathy.Farrell70@hotmail.com", "39WyNceHUmTJcxJiDCQxID/u/Nsu6lE09HbMlb3bc1Q=", "H95PjqcgDx705qBP4ZYroF6ow8eiVLOvBlGzytba7Ro=", new DateTime(2019, 6, 8, 13, 24, 10, 865, DateTimeKind.Local).AddTicks(8809), "Esteban_Lynch" });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_PostReactions_PostId_UserId",
                table: "PostReactions");

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 8, new DateTime(2019, 4, 10, 13, 42, 27, 539, DateTimeKind.Local).AddTicks(9429), new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(424), 8 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 12, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1237), false, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1250), 1 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 20, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1291), true, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1296), 11 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 17, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1326), true, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1331), 16 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 7, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1356), true, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1361), 13 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 16, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1385), new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1390), 13 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 5, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1414), false, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1418), 16 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 12, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1443), false, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1448), 4 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 5, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1476), new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1481), 20 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 7, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1505), new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1510), 15 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 16, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1534), new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1538), 1 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 18, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1563), new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1567), 9 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 1, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1614), false, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1620), 10 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 20, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1646), new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1651), 9 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 2, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1678), new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1682), 12 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 7, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1707), new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1711), 18 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 1, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1735), new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1740), 18 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 4, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1763), false, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1768), 9 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 4, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1791), true, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1796), 15 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 2, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1825), new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1830), 17 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 10, "Odio earum expedita eos magnam voluptas quia aut ipsum.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(1617), 3, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(2611) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { "Illum et neque facilis.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3483), 14, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3498) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 8, "Ullam magnam quis nemo eum dolor quaerat eum.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3603), 10, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 16, "Fugiat delectus aspernatur soluta sit sed provident nostrum et.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3691), 19, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3698) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 6, "Modi in officiis itaque et et quas.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3759), 8, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3766) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 6, "Reiciendis quia perspiciatis et quidem.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3830), 8, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 3, "Et accusamus ea voluptatem harum dolorem eaque eos ducimus fuga.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3906), 10, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3913) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 16, "Rerum iure libero voluptatem.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3983), new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3990) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 3, "Possimus dolor fugiat modi voluptatum rem doloribus necessitatibus dolores.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4056), 19, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4063) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 19, "Recusandae molestias eius ipsa sit.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4120), 19, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4126) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 18, "Ut commodi sed aut ratione saepe sed doloremque.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4188), 18, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4194) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 4, "Et assumenda sint labore voluptatem eaque dolor nulla neque quia.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4281), 1, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4289) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 8, "Quisquam vero unde et qui.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4350), 10, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4356) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 21, "Repellendus quibusdam earum qui.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4420), 20, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4427) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 2, "Culpa enim a.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4479), 6, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4486) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 19, "Asperiores corrupti quam enim.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4538), 1, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 16, "Inventore dolor provident.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4593), 8, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 13, "Nesciunt nostrum ut unde corporis rem reprehenderit libero quia ut.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4665), 17, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 2, "Sunt odit voluptatem saepe eius.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4725), 15, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4732) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 18, "Est consequatur consequuntur eum.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4880), 7, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(4888) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 288, DateTimeKind.Local).AddTicks(1098), "https://s3.amazonaws.com/uifaces/faces/twitter/belyaev_rs/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 288, DateTimeKind.Local).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(576), "https://s3.amazonaws.com/uifaces/faces/twitter/bpartridge/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(590) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(630), "https://s3.amazonaws.com/uifaces/faces/twitter/martip07/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(636) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(668), "https://s3.amazonaws.com/uifaces/faces/twitter/ricburton/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(674) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(697), "https://s3.amazonaws.com/uifaces/faces/twitter/sreejithexp/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(702) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(725), "https://s3.amazonaws.com/uifaces/faces/twitter/longlivemyword/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(754), "https://s3.amazonaws.com/uifaces/faces/twitter/ajaxy_ru/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(759) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(782), "https://s3.amazonaws.com/uifaces/faces/twitter/kalmerrautam/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(787) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(817), "https://s3.amazonaws.com/uifaces/faces/twitter/gonzalorobaina/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(844), "https://s3.amazonaws.com/uifaces/faces/twitter/vitor376/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(850) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(872), "https://s3.amazonaws.com/uifaces/faces/twitter/baumannzone/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(877) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(900), "https://s3.amazonaws.com/uifaces/faces/twitter/andreas_pr/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(905) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(928), new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(933) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(963), "https://s3.amazonaws.com/uifaces/faces/twitter/timothycd/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(968) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(991), "https://s3.amazonaws.com/uifaces/faces/twitter/adobi/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(996) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(1231), "https://s3.amazonaws.com/uifaces/faces/twitter/moynihan/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(1240) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(1282), "https://s3.amazonaws.com/uifaces/faces/twitter/weavermedia/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(1288) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(1312), "https://s3.amazonaws.com/uifaces/faces/twitter/nvkznemo/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(1340), "https://s3.amazonaws.com/uifaces/faces/twitter/exentrich/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(1345) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(1369), "https://s3.amazonaws.com/uifaces/faces/twitter/cbracco/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(906), "https://picsum.photos/640/480/?image=392", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2289), "https://picsum.photos/640/480/?image=425", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2301) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2335), "https://picsum.photos/640/480/?image=784", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2365), "https://picsum.photos/640/480/?image=758", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2370) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2392), "https://picsum.photos/640/480/?image=726", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2419), "https://picsum.photos/640/480/?image=866", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2423) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2445), "https://picsum.photos/640/480/?image=557", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2471), "https://picsum.photos/640/480/?image=263", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2475) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2498), "https://picsum.photos/640/480/?image=60", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2503) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2593), "https://picsum.photos/640/480/?image=222", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2599) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2625), "https://picsum.photos/640/480/?image=201", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2651), "https://picsum.photos/640/480/?image=217", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2656) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2678), "https://picsum.photos/640/480/?image=730", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2682) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2705), "https://picsum.photos/640/480/?image=1061", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2709) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2731), "https://picsum.photos/640/480/?image=52", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2758), "https://picsum.photos/640/480/?image=467", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2784), "https://picsum.photos/640/480/?image=385", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2810), "https://picsum.photos/640/480/?image=19", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2814) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2836), "https://picsum.photos/640/480/?image=341", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2840) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2862), "https://picsum.photos/640/480/?image=685", new DateTime(2019, 4, 10, 13, 42, 27, 295, DateTimeKind.Local).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(2442), true, 1, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(3481), 4 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4462), 1, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4478), 4 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4526), true, 16, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4531), 17 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4560), true, 14, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4565), 16 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4592), 11, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4597), 19 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4624), 17, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4628), 11 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4655), 19, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4660), 12 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4685), false, 18, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4690), 17 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4715), true, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4720), 15 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4744), 19, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4749), 10 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4773), true, 10, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4778), 4 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4812), true, 10, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4818), 20 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4843), true, 8, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4848), 15 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4873), 6, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4878), 6 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4904), 4, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4909), 1 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4933), 18, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4938), 10 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4962), 17, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4967), 18 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4991), 6, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4996), 21 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(5021), 8, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(5026), 13 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(5049), 11, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(5054), 20 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 14, "molestiae", new DateTime(2019, 4, 10, 13, 42, 27, 514, DateTimeKind.Local).AddTicks(4538), 29, new DateTime(2019, 4, 10, 13, 42, 27, 514, DateTimeKind.Local).AddTicks(5593) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 9, @"Nisi quia sunt sapiente sapiente quia maiores iure.
Non rerum pariatur rem id autem.
Accusantium iure odio et possimus.
Rerum illum ut unde sed qui aperiam corrupti.
Et enim repellendus dolor inventore inventore unde cupiditate tempore.
Aut possimus temporibus pariatur at voluptas dolor minima.", new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(5149), 32, new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 9, "Sapiente itaque fuga sed ad.", new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(7346), 40, new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 20, "sed", new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(7457), 28, new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 17, @"Est nihil id corporis voluptatum eos voluptas.
Tenetur delectus pariatur ut.", new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(7654), 23, new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { "Rem aspernatur excepturi et.", new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(7754), 27, new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(7761) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 19, @"Iste aut et qui qui consequatur ipsa aut minima.
Ea perspiciatis aliquam.
Voluptate occaecati id voluptatibus expedita nobis nemo officiis harum quisquam.
Aut pariatur ut molestiae ut.", new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(7926), 37, new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 16, "sint", new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(7985), 39, new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 4, "vitae", new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(8036), 31, new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 21, "Cumque reiciendis et numquam sit aut explicabo sunt et. Quo deleniti nobis voluptatum eveniet dolor sunt a aut vel. Labore quos voluptas.", new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(1677), 35, new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 1, @"Voluptatum dolores officiis qui aperiam recusandae quod minus.
Libero dolores sit eligendi reiciendis delectus vel eaque.
Ad aliquam corporis recusandae.", new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(1890), 25, new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 8, "Corrupti corporis voluptatum sit dignissimos est. Iure ea sapiente laboriosam et perspiciatis nesciunt quae et quis. Quae voluptatem voluptatem non hic cumque voluptas vel. Ut perspiciatis exercitationem. Ex quia totam magnam et amet corrupti est est. Officia natus quam optio culpa minus aspernatur quaerat accusantium.", new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(2146), new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 21, @"Sapiente ex omnis quam.
Id sunt voluptas.
Explicabo voluptatibus dignissimos.
Et laborum quisquam.", new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(2261), 37, new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(2268) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 11, "Tempore delectus non consequatur sit est voluptatem.", new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(2455), 22, new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(2464) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 1, "Dolorum optio ut nostrum beatae velit et.", new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(2541), 33, new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(2547) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 7, "maxime", new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(2591), 29, new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(2597) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 17, @"Consectetur est nemo fugit ea exercitationem a non.
Dolorem assumenda ut quam qui corrupti voluptas qui error commodi.", new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(2709), 35, new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(2716) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 16, @"Minus ex odio aliquid molestiae.
Sed nostrum quae doloribus eum odio quia.
Ipsum quia quod id exercitationem.
Rerum fugiat quia esse impedit.", new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(2846), 29, new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 19, "Pariatur in aut alias eum alias. Est id voluptatum fuga deleniti amet et facere quae. Totam reprehenderit ipsa. Quasi voluptatem veniam.", new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(2984), 34, new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 11, "voluptatem", new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(3034), 33, new DateTime(2019, 4, 10, 13, 42, 27, 517, DateTimeKind.Local).AddTicks(3041) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 4, new DateTime(2019, 4, 10, 13, 42, 27, 354, DateTimeKind.Local).AddTicks(9279), "Eleanore78@hotmail.com", "JwhgJRWNi9KZ6HvsVC4o3ATXPKrIl6NpFs14Ywn6XcQ=", "1ZKXAVI9IEeT90K/cc4u5/9FM9h5NSvHrOT3p8VVgXk=", new DateTime(2019, 4, 10, 13, 42, 27, 355, DateTimeKind.Local).AddTicks(557), "Reanna.Berge" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 362, DateTimeKind.Local).AddTicks(6332), "Noel37@gmail.com", "Ov/w2Ir6JjrZM+lrZWDJZQdRTyrjeX3kkEV1sNq5DLM=", "81E5KuSfD6Wy6OFVRVrzJi2uxOmPDeOHy31ZANgLikw=", new DateTime(2019, 4, 10, 13, 42, 27, 362, DateTimeKind.Local).AddTicks(6356), "Trevion.Konopelski" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 18, new DateTime(2019, 4, 10, 13, 42, 27, 370, DateTimeKind.Local).AddTicks(1374), "Tyree.Hettinger5@hotmail.com", "IFV9xQIA/JkXs2hSSZbxmkQc94MfDE6An6s8rISbMYo=", "lt+NT9Cw+2mitIPEmnHcp4xH3eoNtuwBukz7l2yl2Rg=", new DateTime(2019, 4, 10, 13, 42, 27, 370, DateTimeKind.Local).AddTicks(1394), "Raoul_Armstrong" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2019, 4, 10, 13, 42, 27, 377, DateTimeKind.Local).AddTicks(6273), "Landen82@gmail.com", "pel2LSd08C+t2mEhX1uBO7rVCWTaKiAjkqj43O1ytxo=", "W/OnJ8Ygem16yrXzV3ijvpYdye+/hgN2MeIiz/j9spM=", new DateTime(2019, 4, 10, 13, 42, 27, 377, DateTimeKind.Local).AddTicks(6291), "Tamara_Heaney59" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 13, new DateTime(2019, 4, 10, 13, 42, 27, 385, DateTimeKind.Local).AddTicks(1240), "Ashlee_Walker@gmail.com", "Ty1WmblkkeeehqZtK993rkptymgJ4HHmP3FtlQwggTQ=", "xmkPKualMGfdZNrMieig0XspCqfUdXIsiM9n+hH0BNM=", new DateTime(2019, 4, 10, 13, 42, 27, 385, DateTimeKind.Local).AddTicks(1258), "April.Baumbach63" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 5, new DateTime(2019, 4, 10, 13, 42, 27, 392, DateTimeKind.Local).AddTicks(4481), "Vern_Yost17@hotmail.com", "UrtG6PTWOuZN01Y0wJW2RXzWQztXetNZKLMXY2kPapU=", "nI8AsOHQ9rdpquComXIuzdUI83EJA5Ebtk53tHp8okM=", new DateTime(2019, 4, 10, 13, 42, 27, 392, DateTimeKind.Local).AddTicks(4494), "Jessy_Trantow70" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 11, new DateTime(2019, 4, 10, 13, 42, 27, 400, DateTimeKind.Local).AddTicks(1588), "Octavia.Breitenberg15@gmail.com", "JEPtNmc+xcRh6dRMz0XpW3YjPfo70dx6ghqpRbR7qZ8=", "QkAvLRdlO782y7r9/FQ5BeOVYPCV2OixVUgbJ0x0kZQ=", new DateTime(2019, 4, 10, 13, 42, 27, 400, DateTimeKind.Local).AddTicks(1618), "Brionna_Huel" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 20, new DateTime(2019, 4, 10, 13, 42, 27, 407, DateTimeKind.Local).AddTicks(5516), "Jaida.Robel@yahoo.com", "2sM5eXjzXM4rit4n0XznRgPXWrMUrkM2NEYIt8wWdM0=", "uZISArgxWHVs5sNqC3KY/zSN2GC6+cQ4PbSZXd2tY/w=", new DateTime(2019, 4, 10, 13, 42, 27, 407, DateTimeKind.Local).AddTicks(5528), "Idella67" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 4, new DateTime(2019, 4, 10, 13, 42, 27, 415, DateTimeKind.Local).AddTicks(286), "Merle3@hotmail.com", "vPqcCQvAy3m0ApPP9wTVPS+S6M+kffrzhI0KKY5byUE=", "73Y6XFrs5GNfbX3gEPnUriXG+09YbIzyLCyKeTM4d/4=", new DateTime(2019, 4, 10, 13, 42, 27, 415, DateTimeKind.Local).AddTicks(305), "Francesca_McClure" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 8, new DateTime(2019, 4, 10, 13, 42, 27, 422, DateTimeKind.Local).AddTicks(5128), "Destin87@gmail.com", "3OzL76X0wfbkPwt7JQPH+/ebvc9xfBO3bcFQunQ0v4c=", "E4foLxFiXVPkgaoQ+Tr6Ge0g6OSnwWDa3eNX3Y0ExT4=", new DateTime(2019, 4, 10, 13, 42, 27, 422, DateTimeKind.Local).AddTicks(5147), "Ben.Legros80" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 430, DateTimeKind.Local).AddTicks(2390), "Finn84@gmail.com", "izsFaOQN3vHcHSvx8GGNmww7cWdIFOMBLISdizTYcw8=", "QwJmN2g2pIq3vU+epDXifJpLcfBOM84mE8O97MdJkzg=", new DateTime(2019, 4, 10, 13, 42, 27, 430, DateTimeKind.Local).AddTicks(2408), "Claudie_Von90" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 6, new DateTime(2019, 4, 10, 13, 42, 27, 437, DateTimeKind.Local).AddTicks(7089), "Brady24@yahoo.com", "fvm+iVG/i1teAwJu6gjd99cM3VzEf33Q4lZmpYa3gtA=", "qwNd4zHDb4xaQdyEy9lNs/c4y5rsfGTbauvyVwf8COc=", new DateTime(2019, 4, 10, 13, 42, 27, 437, DateTimeKind.Local).AddTicks(7102), "Bertha_Kuhic" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 13, new DateTime(2019, 4, 10, 13, 42, 27, 445, DateTimeKind.Local).AddTicks(471), "Amira84@yahoo.com", "OO/o8dRJNQHE/Cy5SsMuUoV59W4CfSqsYA1JYbnBbKA=", "BcFPRW2kgTsEIJrwMiZMtEJGYYttXjV8hE2B6jCKgSQ=", new DateTime(2019, 4, 10, 13, 42, 27, 445, DateTimeKind.Local).AddTicks(482), "Roxane.Bechtelar" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 17, new DateTime(2019, 4, 10, 13, 42, 27, 452, DateTimeKind.Local).AddTicks(5168), "Reagan_Gottlieb96@gmail.com", "8/CAtMOKHMOIgZYZyjfPyFgxlGUPh2TRexcrWcVuKR0=", "N4HTAz9evQh9HSBh4Ui10gobECk9Re8EzmJd04m9PKc=", new DateTime(2019, 4, 10, 13, 42, 27, 452, DateTimeKind.Local).AddTicks(5186), "Willow84" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 10, new DateTime(2019, 4, 10, 13, 42, 27, 460, DateTimeKind.Local).AddTicks(40), "Dane_Toy25@hotmail.com", "5ksghg+QRIoR4HCwib/D71e6GWEgIzgvHUy+/jIU8u4=", "YHCWI8ogFKXeVnbDjONhQnBcwOv9KTCv65i5aPHgxy4=", new DateTime(2019, 4, 10, 13, 42, 27, 460, DateTimeKind.Local).AddTicks(52), "Lyric_Powlowski" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2019, 4, 10, 13, 42, 27, 467, DateTimeKind.Local).AddTicks(7399), "Clyde.Kunze@gmail.com", "jN562rlj3Y4M9JiXhpaq22V9r5A0MCACnb8p5a03L24=", "PDjMLphnPnJG54zhHoLXWCW2Jr4kTqmaumBZuqRp0GM=", new DateTime(2019, 4, 10, 13, 42, 27, 467, DateTimeKind.Local).AddTicks(7433), "Kevon45" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 15, new DateTime(2019, 4, 10, 13, 42, 27, 475, DateTimeKind.Local).AddTicks(6227), "Chanel.Champlin68@hotmail.com", "AH5M8V4Q25IYweo/q/iVqQQ4h/xed8dxtZE0aeS5cWM=", "73owabAASkyG0Dvg2TnKlvWRX0FzS0ur49Ur3J5H3qM=", new DateTime(2019, 4, 10, 13, 42, 27, 475, DateTimeKind.Local).AddTicks(6272), "Jewell_Schmitt" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 4, new DateTime(2019, 4, 10, 13, 42, 27, 483, DateTimeKind.Local).AddTicks(1289), "Watson.Bahringer@yahoo.com", "Q62jzI0XYrLxW7Vfi/yI+uS4YjSlRcUbQZxMQGfc8C0=", "vSbXm9StFleAMjE1o2oRvdW3lJHYt7hkHrsLCa7Dg4U=", new DateTime(2019, 4, 10, 13, 42, 27, 483, DateTimeKind.Local).AddTicks(1302), "Jazmin98" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 13, new DateTime(2019, 4, 10, 13, 42, 27, 490, DateTimeKind.Local).AddTicks(5812), "Aditya.Kerluke@yahoo.com", "7D2UgGVDo4CTiK0CFT/Cd2Kryi7caZwemc5a7f9Xus8=", "zUsIM0NUWcyfmuUZWfbZD/ip+Wl+JZe/hLUSru5/rSM=", new DateTime(2019, 4, 10, 13, 42, 27, 490, DateTimeKind.Local).AddTicks(5824), "Josefa_Brakus" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 8, new DateTime(2019, 4, 10, 13, 42, 27, 498, DateTimeKind.Local).AddTicks(265), "Stewart.Kiehn@hotmail.com", "huLmL4GntVXBmnUFICkmowedAskr5IoAk5wW5424zqQ=", "AmgoIHeRfU91KKABVopqN9E6rEyTLpgLW9RqszTP2zc=", new DateTime(2019, 4, 10, 13, 42, 27, 498, DateTimeKind.Local).AddTicks(276), "Margaretta_Schaden" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Password", "Salt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 505, DateTimeKind.Local).AddTicks(3866), "C+XvvutUOnUo6U86oKynPexTPQkkhKfd4pYAf+LzYPE=", "wBQhcRU+Nh0iNrhTwxtzwOXjMhOxlLTx5BkVJ3h6sB4=", new DateTime(2019, 4, 10, 13, 42, 27, 505, DateTimeKind.Local).AddTicks(3866) });

            migrationBuilder.CreateIndex(
                name: "IX_PostReactions_PostId",
                table: "PostReactions",
                column: "PostId");
        }
    }
}
