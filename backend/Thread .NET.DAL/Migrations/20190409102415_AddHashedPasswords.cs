using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Thread_.NET.DAL.Migrations
{
    public partial class AddHashedPasswords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Salt",
                table: "Users",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 20, new DateTime(2019, 4, 9, 13, 24, 15, 375, DateTimeKind.Local).AddTicks(8003), new DateTime(2019, 4, 9, 13, 24, 15, 375, DateTimeKind.Local).AddTicks(8991), 6 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 10, new DateTime(2019, 4, 9, 13, 24, 15, 375, DateTimeKind.Local).AddTicks(9915), new DateTime(2019, 4, 9, 13, 24, 15, 375, DateTimeKind.Local).AddTicks(9929), 2 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 8, new DateTime(2019, 4, 9, 13, 24, 15, 375, DateTimeKind.Local).AddTicks(9973), false, new DateTime(2019, 4, 9, 13, 24, 15, 375, DateTimeKind.Local).AddTicks(9978), 4 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 4, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(6), false, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(11), 14 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 20, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(40), new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(45), 1 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 16, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(74), new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(79), 7 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 4, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(105), true, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(110), 17 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 9, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(136), false, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(142), 20 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 1, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(184), new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(191), 17 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 8, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(221), true, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(226), 10 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 17, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(252), new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(258), 1 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 5, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(284), false, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(289), 20 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 3, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(325), true, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(330), 16 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 4, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(357), true, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(363), 13 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 5, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(389), true, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(394), 19 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 8, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(425), false, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(430), 8 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 12, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(457), new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(462), 12 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 17, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(488), false, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(494), 11 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 7, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(520), new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(525), 12 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 6, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(551), new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(556), 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 20, "Eos odio repellat officia voluptatem incidunt ut ex nisi non.", new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(826), 4, new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 6, "Amet repudiandae voluptatem recusandae et.", new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(2571), 10, new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(2586) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 8, "Ab nostrum et eveniet nostrum molestias numquam quos aut nisi.", new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(2675), 15, new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(2682) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 17, "Adipisci et velit animi fugiat optio quos nesciunt.", new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(2763), new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 7, "Nesciunt ut perspiciatis magnam aut.", new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(2829), 19, new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 8, "Corrupti tenetur dicta voluptatem dolores est doloremque quisquam facere eos.", new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(2909), 12, new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(2915) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 12, "Molestiae fuga asperiores velit est suscipit nam.", new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(2978), 20, new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 9, "Ad unde ipsum id rerum sapiente sapiente occaecati est.", new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(3049), 9, new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(3056) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 17, "Assumenda odit ut sint voluptates.", new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(3118), 20, new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(3124) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 8, "Ullam dignissimos nesciunt facere qui est omnis voluptas.", new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(3187), 20, new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(3194) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 7, "Consequatur excepturi ratione vel id.", new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(3249), new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 14, "Possimus autem nisi.", new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(3306), new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 15, "Quia at rerum et.", new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(3365), 9, new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 3, "Error labore molestias eum reprehenderit quam aut modi velit.", new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(3435), 4, new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(3441) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { "Aut veritatis quod fuga exercitationem maxime deserunt sapiente.", new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(3512), 5, new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(3519) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 9, "A quibusdam delectus id iste accusamus libero est tempore error.", new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(3586), 17, new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(3592) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 19, "Rerum voluptatibus non et earum.", new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(3647), 7, new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(3653) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 3, "Consectetur earum beatae vitae et incidunt officia voluptatem.", new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(3712), 10, new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(3719) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 9, "Ut exercitationem unde aperiam.", new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(3770), 17, new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(3776) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 6, "Aliquid maxime aliquid deleniti eos nobis.", new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(3830), 10, new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(3837) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 138, DateTimeKind.Local).AddTicks(2702), "https://s3.amazonaws.com/uifaces/faces/twitter/woodydotmx/128.jpg", new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(258) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(1763), "https://s3.amazonaws.com/uifaces/faces/twitter/uberschizo/128.jpg", new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(1778) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(1819), "https://s3.amazonaws.com/uifaces/faces/twitter/aaronalfred/128.jpg", new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(1855), "https://s3.amazonaws.com/uifaces/faces/twitter/johnriordan/128.jpg", new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(1861) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(1886), "https://s3.amazonaws.com/uifaces/faces/twitter/petebernardo/128.jpg", new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(1890) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(1914), "https://s3.amazonaws.com/uifaces/faces/twitter/brenton_clarke/128.jpg", new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(1919) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(1942), "https://s3.amazonaws.com/uifaces/faces/twitter/carlfairclough/128.jpg", new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(1969), "https://s3.amazonaws.com/uifaces/faces/twitter/sasha_shestakov/128.jpg", new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(2004), "https://s3.amazonaws.com/uifaces/faces/twitter/jwalter14/128.jpg", new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(2008) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(2032), "https://s3.amazonaws.com/uifaces/faces/twitter/mwarkentin/128.jpg", new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(2060), "https://s3.amazonaws.com/uifaces/faces/twitter/ManikRathee/128.jpg", new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(2065) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(2087), "https://s3.amazonaws.com/uifaces/faces/twitter/michigangraham/128.jpg", new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(2092) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(2112), "https://s3.amazonaws.com/uifaces/faces/twitter/uberschizo/128.jpg", new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(2117) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(2139), "https://s3.amazonaws.com/uifaces/faces/twitter/roxanejammet/128.jpg", new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(2144) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(2167), "https://s3.amazonaws.com/uifaces/faces/twitter/dnirmal/128.jpg", new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(2196), "https://s3.amazonaws.com/uifaces/faces/twitter/mhaligowski/128.jpg", new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(2224), "https://s3.amazonaws.com/uifaces/faces/twitter/mangosango/128.jpg", new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(2251), "https://s3.amazonaws.com/uifaces/faces/twitter/reetajayendra/128.jpg", new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(2256) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(2279), "https://s3.amazonaws.com/uifaces/faces/twitter/vickyshits/128.jpg", new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(2307), "https://s3.amazonaws.com/uifaces/faces/twitter/isaacfifth/128.jpg", new DateTime(2019, 4, 9, 13, 24, 15, 139, DateTimeKind.Local).AddTicks(2312) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(46), "https://picsum.photos/640/480/?image=290", new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(1178) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(1469), "https://picsum.photos/640/480/?image=342", new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(1480) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(1512), "https://picsum.photos/640/480/?image=271", new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(1518) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(1543), "https://picsum.photos/640/480/?image=462", new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(1572), "https://picsum.photos/640/480/?image=251", new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(1599), "https://picsum.photos/640/480/?image=514", new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(1628), "https://picsum.photos/640/480/?image=1082", new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(1633) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(1765), "https://picsum.photos/640/480/?image=290", new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(1810), "https://picsum.photos/640/480/?image=463", new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(1815) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(1839), "https://picsum.photos/640/480/?image=277", new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(1866), "https://picsum.photos/640/480/?image=503", new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(1893), "https://picsum.photos/640/480/?image=705", new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(1898) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(1920), "https://picsum.photos/640/480/?image=240", new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(1925) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(1949), "https://picsum.photos/640/480/?image=0", new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(1977), "https://picsum.photos/640/480/?image=254", new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(1982) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(2005), "https://picsum.photos/640/480/?image=433", new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(2010) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(2033), "https://picsum.photos/640/480/?image=265", new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(2061), "https://picsum.photos/640/480/?image=119", new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(2088), "https://picsum.photos/640/480/?image=543", new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(2093) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(2116), "https://picsum.photos/640/480/?image=814", new DateTime(2019, 4, 9, 13, 24, 15, 145, DateTimeKind.Local).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(5394), false, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(6327), 7 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7394), 18, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7410), 1 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7459), false, 16, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7464), 6 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7549), 11, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7556), 19 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7588), 2, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7594), 14 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7627), true, 3, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7632), 12 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7661), true, 20, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7666), 10 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7693), 16, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7698), 20 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7725), 11, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7730), 11 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7757), false, 15, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7763), 7 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7790), 17, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7795), 9 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7822), 6, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7828), 6 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7855), false, 9, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7860), 9 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7914), true, 1, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7921), 11 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7951), 11, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7957), 4 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7983), 15, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7989), 7 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(8016), 19, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(8021), 19 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(8048), true, 17, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(8053), 9 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(8080), 8, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(8085), 19 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(8112), false, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(8118), 13 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 12, "id", new DateTime(2019, 4, 9, 13, 24, 15, 352, DateTimeKind.Local).AddTicks(605), 21, new DateTime(2019, 4, 9, 13, 24, 15, 352, DateTimeKind.Local).AddTicks(1506) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 2, @"Quos veniam quam sint aut dolor autem.
Nemo occaecati tempora et magni voluptatum rerum voluptas a aspernatur.
Quia perspiciatis cum sed reiciendis optio nobis est architecto.
Sapiente voluptatem omnis asperiores saepe id nostrum quo.
Aut tempore commodi molestiae aut nihil quos amet libero at.
Ut et dignissimos tenetur.", new DateTime(2019, 4, 9, 13, 24, 15, 353, DateTimeKind.Local).AddTicks(9585), 35, new DateTime(2019, 4, 9, 13, 24, 15, 353, DateTimeKind.Local).AddTicks(9609) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 11, "Eius molestiae sunt corporis veniam ut. Cum iusto labore accusamus. Non ab quia beatae possimus dolorum libero.", new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(2842), 34, new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(2859) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, @"Eos nihil eveniet officiis mollitia veniam dolorem temporibus quia.
Est unde aut inventore facilis nam.", new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(3019), 25, new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(3027) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 19, @"Laborum ipsa sit quia officiis tenetur ducimus voluptatem rem a.
Velit qui odio in ducimus sit beatae sequi.
Vitae rem provident ea sunt reiciendis.
Reiciendis alias voluptatum nam omnis culpa assumenda magnam.", new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(3196), 34, new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(3204) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 1, @"Vel rerum est iusto voluptatibus.
Minima dolorum et numquam.
Id deserunt voluptatem ut qui molestias expedita facere eveniet aliquam.
Ratione repellat exercitationem rerum eum ab.
Repudiandae similique dolor ea.", new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(3397), 37, new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 12, "Aspernatur autem iusto optio beatae voluptates temporibus officia molestiae.", new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(5435), 24, new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(5451) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 5, "Modi quibusdam dolorem quasi. Quos est qui aperiam nemo tempora et sequi facilis odit. Voluptas doloribus blanditiis ipsam voluptate veniam.", new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(5634), 27, new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { "iste", new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(5700), 28, new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 4, "Enim sit vitae possimus ut maiores sed possimus sed.", new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(5792), 40, new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 11, "Totam facilis possimus ratione. Perspiciatis ea sunt velit autem maxime. Deleniti fuga saepe aliquid eos labore est aliquam eaque quae. Qui exercitationem sed nulla aut.", new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(5941), 38, new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(5948) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 4, "qui", new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(5988), 39, new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(5995) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 8, @"Quia non qui autem optio est nostrum aut voluptate.
Voluptates eos assumenda vel itaque sit sunt.
Nihil exercitationem commodi.
Commodi cumque qui nihil et est exercitationem alias nostrum.", new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(6139), 38, new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(6146) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 6, @"Tenetur aut laboriosam enim veritatis.
Necessitatibus laborum itaque ratione aut eligendi.
Ut pariatur explicabo nemo.
Odio ea error quia.
Doloribus accusamus rerum quo ea numquam sit quas numquam rerum.
Incidunt non facere voluptatem ut reiciendis a placeat.", new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(6325), 36, new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 14, @"Doloremque sequi adipisci officia quia fugit.
Maxime fugiat ut ut ea quam tempore.
In et rerum rerum aut culpa.", new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(6444), 21, new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(6452) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 16, "Alias praesentium in vel.", new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(6505), 28, new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(6512) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 9, "Adipisci nobis dolore sit molestiae vel aspernatur ipsam.", new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(6810), 38, new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 16, "Maxime vel nemo rem aliquid nulla.", new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(6895), 33, new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 3, new DateTime(2019, 4, 9, 13, 24, 15, 196, DateTimeKind.Local).AddTicks(535), "Ken_Pagac79@yahoo.com", "pfkAAERlaKZGpSoosXQv2STYuj9C6T9adhtY6R/tQc0=", "YFaJO9bxuzOsPgmKisSMBnl9XDpgs9YlAr+YjjnXkBA=", new DateTime(2019, 4, 9, 13, 24, 15, 196, DateTimeKind.Local).AddTicks(1534), "Roger.Heller82" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 10, new DateTime(2019, 4, 9, 13, 24, 15, 203, DateTimeKind.Local).AddTicks(6436), "Ayana.Tillman23@yahoo.com", "tFBIJD2uh+PGb/4Umi1HG18sT3TDKsOCGtUkYTEand8=", "jHv1QO2TJQPiBkgmhb9riatiAcUlh+wU/XelizfIr6A=", new DateTime(2019, 4, 9, 13, 24, 15, 203, DateTimeKind.Local).AddTicks(6456), "Dion_Gottlieb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2019, 4, 9, 13, 24, 15, 210, DateTimeKind.Local).AddTicks(9499), "Rosamond.Kassulke@yahoo.com", "pHRYMbBXQRA0KfBkr5A8Ruy5xsoDkO++31J9GjJ1Frs=", "hNiwrP7KTMkF9z1WHJiA7y2yDgPOodPUIH1rWraOKHk=", new DateTime(2019, 4, 9, 13, 24, 15, 210, DateTimeKind.Local).AddTicks(9513), "Ephraim_Mayer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2019, 4, 9, 13, 24, 15, 218, DateTimeKind.Local).AddTicks(3689), "Eliezer.Beahan18@yahoo.com", "QZgFrTWNUBT6UxHRB3C20Yk2MiKimp2p65E+J6sbcxA=", "Sj2lGS4odCzRYtG+eUi1ciA1QpI+AttYtubarmMaUrI=", new DateTime(2019, 4, 9, 13, 24, 15, 218, DateTimeKind.Local).AddTicks(3701), "Muriel10" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 1, new DateTime(2019, 4, 9, 13, 24, 15, 225, DateTimeKind.Local).AddTicks(8095), "Modesta_Tromp72@hotmail.com", "9qXAw4jZqDoytixijV/7XH6tmDcNtAlosY8TFxz4PC8=", "0eXbXJ5Tn3laM70sfBsYN/Iyq4v1vICE/gXNj6R5tPE=", new DateTime(2019, 4, 9, 13, 24, 15, 225, DateTimeKind.Local).AddTicks(8111), "Cristal.Sipes9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 1, new DateTime(2019, 4, 9, 13, 24, 15, 233, DateTimeKind.Local).AddTicks(289), "Stefan82@hotmail.com", "BxKoC66yMimtJBEBCOkj54546OBlo4O1TEQZ4nnAHOI=", "oVjq0dVE8GbvbGZEn+5D7YRWOIoV6LQhJfJwB3Am3KI=", new DateTime(2019, 4, 9, 13, 24, 15, 233, DateTimeKind.Local).AddTicks(299), "Princess.Morar50" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 13, new DateTime(2019, 4, 9, 13, 24, 15, 240, DateTimeKind.Local).AddTicks(2868), "Marlon82@gmail.com", "NtLY69mKUfg3tKyRw9p315Vzk/CDdj7CD1+BBLFIAu8=", "57wQECEYBl3F7tfqqdLTIB3WAwH+tHsPYJefQ5ufjgY=", new DateTime(2019, 4, 9, 13, 24, 15, 240, DateTimeKind.Local).AddTicks(2880), "Mallory8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 15, new DateTime(2019, 4, 9, 13, 24, 15, 247, DateTimeKind.Local).AddTicks(9204), "Serena_Gusikowski78@hotmail.com", "3hsSYfg/hDuJLjm41E0i0TJ+JN2S39AbI/0gpu2xho8=", "L7Crlt8cgeygzIz5aE4lWvpKCuBEhFjd/Wn94QDmh3E=", new DateTime(2019, 4, 9, 13, 24, 15, 247, DateTimeKind.Local).AddTicks(9225), "Cornell.Funk74" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 255, DateTimeKind.Local).AddTicks(2865), "Theresia2@yahoo.com", "KFDa5zRMbIGxH5QBR2Ol/LSW+qhG4oe3KKp6Ux/z5k8=", "0hUyEzKuN4/5Hd19lesOQ+PhITWjD6V72XfSzHyAd04=", new DateTime(2019, 4, 9, 13, 24, 15, 255, DateTimeKind.Local).AddTicks(2885), "Sibyl.Sipes61" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 17, new DateTime(2019, 4, 9, 13, 24, 15, 262, DateTimeKind.Local).AddTicks(7514), "Kayden_Blanda79@gmail.com", "AzKpIYc1nvOlXGPI6Ibf7o5vwpIiGgVY7MGKjyDf1eY=", "yFtlj/1hXc65xsCC63zqLqEsnbrcYS+vnepfO2CnrY4=", new DateTime(2019, 4, 9, 13, 24, 15, 262, DateTimeKind.Local).AddTicks(7538), "Charity_Kirlin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 15, new DateTime(2019, 4, 9, 13, 24, 15, 270, DateTimeKind.Local).AddTicks(1594), "Amie_McClure@hotmail.com", "CW2aSYGxJFu+MkvBJ5IFEjvG1IxPW2ZMuKYGLLX6va8=", "ZIIgrN/QiZUmKZsJ1ISa01fqooNA8/5fCXvO6WiiuME=", new DateTime(2019, 4, 9, 13, 24, 15, 270, DateTimeKind.Local).AddTicks(1610), "Waldo_Kozey" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 12, new DateTime(2019, 4, 9, 13, 24, 15, 277, DateTimeKind.Local).AddTicks(4146), "Simeon_Hane41@gmail.com", "jOrMYDZo2l0GSrkFAuXRuTvGuz5VKuW2s5urDAnQD7g=", "VzdCem7cKtuSF/BJvGCaQcF5oLWvz84zY/zvvXemcHA=", new DateTime(2019, 4, 9, 13, 24, 15, 277, DateTimeKind.Local).AddTicks(4165), "Leonor_Yundt82" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 7, new DateTime(2019, 4, 9, 13, 24, 15, 284, DateTimeKind.Local).AddTicks(7824), "Santiago.Veum25@gmail.com", "sadnp7IXeGVp8HzdbogRFOivQ7JJUJ1ybYqD/R9pF1Q=", "YAYXE84LrZrFCU0iYnZTU3ffjzk2ZhXGmVVp20Aoyf0=", new DateTime(2019, 4, 9, 13, 24, 15, 284, DateTimeKind.Local).AddTicks(7837), "Bert32" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 15, new DateTime(2019, 4, 9, 13, 24, 15, 292, DateTimeKind.Local).AddTicks(3246), "Marie_Lueilwitz24@hotmail.com", "f5RIZhsWRDfpg+7IkIgcSPQmkvlpqV7ERM+Bd/4SdsY=", "YbDmBeVx17oL+XfVWjOgp/sXv3VRHLQRVB1Fw1mDxuc=", new DateTime(2019, 4, 9, 13, 24, 15, 292, DateTimeKind.Local).AddTicks(3260), "Courtney.Brekke" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 10, new DateTime(2019, 4, 9, 13, 24, 15, 299, DateTimeKind.Local).AddTicks(6022), "Lila.Jacobs@hotmail.com", "vEshTnHfB8cZirzWL/SP6u5ivZAJNR9M9/nHeekacwA=", "bnWprq23IAKMEiC1GHkae21P+pSfByeEuC3X1YJZx5o=", new DateTime(2019, 4, 9, 13, 24, 15, 299, DateTimeKind.Local).AddTicks(6035), "Ray_Bashirian93" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 13, new DateTime(2019, 4, 9, 13, 24, 15, 307, DateTimeKind.Local).AddTicks(1721), "Thalia44@yahoo.com", "kzt1wpJtKF8pjKyredXMdKhtrnTjVSuSSJa3eYMuX74=", "/85HEbFQiGVsf6+sEljz4vi1uS8IwGdtUF4GHmkDSas=", new DateTime(2019, 4, 9, 13, 24, 15, 307, DateTimeKind.Local).AddTicks(1740), "Elwyn86" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 18, new DateTime(2019, 4, 9, 13, 24, 15, 314, DateTimeKind.Local).AddTicks(7395), "Shemar.Smitham73@yahoo.com", "FfkvcmfsDPfy8kl0k1YzeunxIEnUxCkv9gXZI6kvDAc=", "dmLJaNVUBnHlQWjzO0orRGzpCGL7iUrbpL0dzEfFs9g=", new DateTime(2019, 4, 9, 13, 24, 15, 314, DateTimeKind.Local).AddTicks(7416), "Antonio65" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 15, new DateTime(2019, 4, 9, 13, 24, 15, 322, DateTimeKind.Local).AddTicks(747), "Kristian_Mann@hotmail.com", "vdyV6lP59TT/3ih0HNwM18am8xkJdWl5NO6ve0Gjb1A=", "woP2bnx4lEpjB1SJho4tcli5mLFUmYhz4XSIcSZ6fb0=", new DateTime(2019, 4, 9, 13, 24, 15, 322, DateTimeKind.Local).AddTicks(760), "Cleora_Veum16" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 20, new DateTime(2019, 4, 9, 13, 24, 15, 329, DateTimeKind.Local).AddTicks(4078), "Bettie.Fay@yahoo.com", "7h5CZ2zO6JI6h6gY9eDxzxyBYeUwBdGT6JqU9dGxKqg=", "Qy12CSaWxtBBHk0uI1OWhFdGRmqp2pC83qrkuqGxaCU=", new DateTime(2019, 4, 9, 13, 24, 15, 329, DateTimeKind.Local).AddTicks(4099), "Elton48" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 7, new DateTime(2019, 4, 9, 13, 24, 15, 336, DateTimeKind.Local).AddTicks(7921), "Cecilia_Jenkins25@hotmail.com", "CoZoTrwW0YAGQjwaJmOPf2MjYDfZBqNzgzJEfgxX+jw=", "+LGKtoj/9p3Z7vAOMpyy0SouvApFV+bzo5Seb1ZLyfQ=", new DateTime(2019, 4, 9, 13, 24, 15, 336, DateTimeKind.Local).AddTicks(7944), "Angie48" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 21, null, new DateTime(2019, 4, 9, 13, 24, 15, 344, DateTimeKind.Local).AddTicks(2203), "test@gmail.com", "jrhihaMkIi7TrH4Hrysf4rs3K7+cdejDTJHEOrLSkjY=", "6POKtXMcxt/8lQvYjfwHCkSKyABbToTh4TfoZzHJefA=", new DateTime(2019, 4, 9, 13, 24, 15, 344, DateTimeKind.Local).AddTicks(2203), "testUser" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 21, "Doloribus sint at et quia et ipsum non voluptatum.", new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(6972), 24, new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 21, @"Labore vel quos voluptatem temporibus corrupti optio facilis sit earum.
Amet sequi non laudantium excepturi quia.
Dolore voluptas eligendi minus dolorem repellat aliquam dignissimos.", new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(7120), 23, new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(7128) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DropColumn(
                name: "Salt",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 14, new DateTime(2019, 4, 8, 19, 12, 33, 122, DateTimeKind.Local).AddTicks(9522), new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(466), 1 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 15, new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1273), new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1287), 3 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 20, new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1332), true, new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1337), 16 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 1, new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1394), true, new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1401), 16 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 13, new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1434), new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1439), 19 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 18, new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1468), new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1473), 17 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 11, new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1501), false, new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1506), 5 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 17, new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1535), true, new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1540), 4 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 10, new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1638), new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1644), 5 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 18, new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1675), false, new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1680), 9 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 10, new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1708), new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1712), 14 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 4, new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1741), true, new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1746), 10 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 5, new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1774), false, new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1779), 10 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 19, new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1806), false, new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1811), 16 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 6, new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1843), false, new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1848), 12 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 4, new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1874), true, new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1879), 17 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 5, new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1906), new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1911), 13 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 1, new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1938), true, new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1943), 16 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 17, new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1970), new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(1975), 19 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 18, new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(2002), new DateTime(2019, 4, 8, 19, 12, 33, 123, DateTimeKind.Local).AddTicks(2006), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 3, "Delectus impedit sit quasi sit earum enim.", new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(3606), 18, new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(4532) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 16, "Non excepturi et accusamus id perferendis.", new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(5514), 7, new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 20, "Et iure sequi similique.", new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(5613), 18, new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 7, "Nihil omnis ut quia eligendi voluptas.", new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(5694), new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 2, "Debitis fugit ex ex.", new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(5760), 3, new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 13, "Et odit aut cum.", new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(5827), 6, new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 5, "Odit eligendi necessitatibus consequuntur voluptatibus quia consequatur qui ipsa.", new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(5967), 17, new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 14, "Quisquam voluptatem iste dolor rerum velit sit.", new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(6051), 18, new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 3, "Quam delectus dolorem molestiae labore et praesentium delectus amet possimus.", new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(6132), 15, new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(6138) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 11, "Et aut sed suscipit error vel id quasi sequi.", new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(6208), 12, new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(6215) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 12, "Repellat rerum voluptas consequuntur deleniti odio.", new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(6279), new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(6285) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 19, "Ad molestiae a illo.", new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(6384), new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(6392) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 14, "Beatae perferendis ab consequatur asperiores nostrum non aut.", new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(6469), 18, new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(6475) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 5, "Corporis sed eum ut esse laborum molestias.", new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(6544), 15, new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { "Quo impedit voluptatem iste.", new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(6608), 14, new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(6614) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 2, "Debitis et veniam harum modi.", new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(6671), 20, new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(6677) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 1, "Et amet nihil nihil.", new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(6731), 8, new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 11, "Dolorum dolorem nostrum pariatur vel aut.", new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(6796), 7, new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 5, "Eligendi dignissimos unde labore nemo qui consequatur.", new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(6917), 13, new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(6924) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 3, "Aspernatur iusto culpa voluptatibus beatae et fugiat.", new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(6989), 19, new DateTime(2019, 4, 8, 19, 12, 33, 104, DateTimeKind.Local).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 61, DateTimeKind.Local).AddTicks(944), "https://s3.amazonaws.com/uifaces/faces/twitter/derienzo777/128.jpg", new DateTime(2019, 4, 8, 19, 12, 33, 61, DateTimeKind.Local).AddTicks(8948) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(87), "https://s3.amazonaws.com/uifaces/faces/twitter/BroumiYoussef/128.jpg", new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(102) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(144), "https://s3.amazonaws.com/uifaces/faces/twitter/gregsqueeb/128.jpg", new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(151) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(176), "https://s3.amazonaws.com/uifaces/faces/twitter/gaborenton/128.jpg", new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(182) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(206), "https://s3.amazonaws.com/uifaces/faces/twitter/salimianoff/128.jpg", new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(211) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(234), "https://s3.amazonaws.com/uifaces/faces/twitter/andrewofficer/128.jpg", new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(239) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(261), "https://s3.amazonaws.com/uifaces/faces/twitter/petebernardo/128.jpg", new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(291), "https://s3.amazonaws.com/uifaces/faces/twitter/mcflydesign/128.jpg", new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(319), "https://s3.amazonaws.com/uifaces/faces/twitter/lu4sh1i/128.jpg", new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(324) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(346), "https://s3.amazonaws.com/uifaces/faces/twitter/el_fuertisimo/128.jpg", new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(375), "https://s3.amazonaws.com/uifaces/faces/twitter/sbtransparent/128.jpg", new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(380) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(403), "https://s3.amazonaws.com/uifaces/faces/twitter/AlbertoCococi/128.jpg", new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(436), "https://s3.amazonaws.com/uifaces/faces/twitter/mrebay007/128.jpg", new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(463), "https://s3.amazonaws.com/uifaces/faces/twitter/thedamianhdez/128.jpg", new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(490), "https://s3.amazonaws.com/uifaces/faces/twitter/itskawsar/128.jpg", new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(518), "https://s3.amazonaws.com/uifaces/faces/twitter/muridrahhal/128.jpg", new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(546), "https://s3.amazonaws.com/uifaces/faces/twitter/olaolusoga/128.jpg", new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(643), "https://s3.amazonaws.com/uifaces/faces/twitter/bartjo/128.jpg", new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(650) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(680), "https://s3.amazonaws.com/uifaces/faces/twitter/Stievius/128.jpg", new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(686) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(710), "https://s3.amazonaws.com/uifaces/faces/twitter/mahmoudmetwally/128.jpg", new DateTime(2019, 4, 8, 19, 12, 33, 62, DateTimeKind.Local).AddTicks(715) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(757), "https://picsum.photos/640/480/?image=192", new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(1845) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2137), "https://picsum.photos/640/480/?image=743", new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2149) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2182), "https://picsum.photos/640/480/?image=763", new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2211), "https://picsum.photos/640/480/?image=374", new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2239), "https://picsum.photos/640/480/?image=49", new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2244) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2268), "https://picsum.photos/640/480/?image=1051", new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2295), "https://picsum.photos/640/480/?image=956", new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2322), "https://picsum.photos/640/480/?image=896", new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2348), "https://picsum.photos/640/480/?image=665", new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2375), "https://picsum.photos/640/480/?image=193", new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2401), "https://picsum.photos/640/480/?image=801", new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2406) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2530), "https://picsum.photos/640/480/?image=972", new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2539) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2573), "https://picsum.photos/640/480/?image=595", new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2578) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2601), "https://picsum.photos/640/480/?image=440", new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2606) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2628), "https://picsum.photos/640/480/?image=880", new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2632) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2654), "https://picsum.photos/640/480/?image=365", new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2659) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2681), "https://picsum.photos/640/480/?image=778", new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2685) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2707), "https://picsum.photos/640/480/?image=253", new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2712) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2734), "https://picsum.photos/640/480/?image=685", new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2761), "https://picsum.photos/640/480/?image=76", new DateTime(2019, 4, 8, 19, 12, 33, 68, DateTimeKind.Local).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(6362), true, new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(7346), 2 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(8301), 8, new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(8316), 16 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(8364), true, 6, new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(8369), 10 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(8401), 7, new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(8407), 6 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(8449), 15, new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(8454), 18 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(8484), false, 11, new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(8490), 16 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(8527), false, 16, new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(8532), 17 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(8562), 2, new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(8567), 4 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(8622), 1, new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(8628), 6 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(8661), true, 5, new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(8666), 17 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(8696), 18, new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(8701), 11 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(8731), 10, new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(8736), 19 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(8875), true, 16, new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(8883), 16 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(8919), false, 5, new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(8925), 5 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(8955), 8, new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(8961), 7 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(8990), 11, new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(8995), 15 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(9030), 7, new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(9035), 1 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(9064), false, 6, new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(9069), 2 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(9098), 19, new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(9104), 2 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(9132), true, new DateTime(2019, 4, 8, 19, 12, 33, 114, DateTimeKind.Local).AddTicks(9137), 6 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 3, "Eos est voluptas libero consequatur fuga quo eius reiciendis.", new DateTime(2019, 4, 8, 19, 12, 33, 94, DateTimeKind.Local).AddTicks(5717), 30, new DateTime(2019, 4, 8, 19, 12, 33, 94, DateTimeKind.Local).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 7, "Necessitatibus non sunt velit est.", new DateTime(2019, 4, 8, 19, 12, 33, 94, DateTimeKind.Local).AddTicks(7892), 23, new DateTime(2019, 4, 8, 19, 12, 33, 94, DateTimeKind.Local).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 14, @"Aut eveniet blanditiis velit et nulla et voluptas voluptatem.
Velit nostrum omnis quam non velit ut.", new DateTime(2019, 4, 8, 19, 12, 33, 95, DateTimeKind.Local).AddTicks(5746), 33, new DateTime(2019, 4, 8, 19, 12, 33, 95, DateTimeKind.Local).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 14, "Quisquam tempore quia ea exercitationem commodi.", new DateTime(2019, 4, 8, 19, 12, 33, 95, DateTimeKind.Local).AddTicks(5925), 31, new DateTime(2019, 4, 8, 19, 12, 33, 95, DateTimeKind.Local).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 20, "neque", new DateTime(2019, 4, 8, 19, 12, 33, 95, DateTimeKind.Local).AddTicks(6834), 25, new DateTime(2019, 4, 8, 19, 12, 33, 95, DateTimeKind.Local).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 15, "Repudiandae nihil explicabo autem dolor distinctio maiores illum accusamus. Sequi libero aut velit est cum earum. Laudantium iure modi dolores autem quia deleniti quaerat dolor alias. Consectetur suscipit pariatur voluptas possimus dolores. Ut nostrum sunt.", new DateTime(2019, 4, 8, 19, 12, 33, 96, DateTimeKind.Local).AddTicks(301), 35, new DateTime(2019, 4, 8, 19, 12, 33, 96, DateTimeKind.Local).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 14, "Qui eligendi nam laudantium perspiciatis corrupti minima ipsa praesentium. Perspiciatis dolor harum est saepe. Deleniti maiores et cum voluptatem corporis ut quia cumque quos. Est dolorem maxime et.", new DateTime(2019, 4, 8, 19, 12, 33, 96, DateTimeKind.Local).AddTicks(538), 28, new DateTime(2019, 4, 8, 19, 12, 33, 96, DateTimeKind.Local).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 15, "Deserunt quo praesentium eveniet repudiandae exercitationem iure et non. Atque assumenda in ipsum labore facere molestiae omnis. Quo autem ut voluptas ab aliquid et.", new DateTime(2019, 4, 8, 19, 12, 33, 96, DateTimeKind.Local).AddTicks(746), 25, new DateTime(2019, 4, 8, 19, 12, 33, 96, DateTimeKind.Local).AddTicks(755) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { @"Facilis officia odit.
Assumenda cupiditate sed omnis ut.", new DateTime(2019, 4, 8, 19, 12, 33, 96, DateTimeKind.Local).AddTicks(859), 39, new DateTime(2019, 4, 8, 19, 12, 33, 96, DateTimeKind.Local).AddTicks(866) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 17, "Consequatur magnam expedita. Ut itaque ut ducimus ut asperiores illo. Voluptate perspiciatis quis beatae libero rerum doloremque laborum quo dolor. Nulla rem tempora saepe perferendis. Et iure et omnis quae maiores autem. Numquam quo et velit velit et aut.", new DateTime(2019, 4, 8, 19, 12, 33, 96, DateTimeKind.Local).AddTicks(1110), 26, new DateTime(2019, 4, 8, 19, 12, 33, 96, DateTimeKind.Local).AddTicks(1118) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, "doloribus", new DateTime(2019, 4, 8, 19, 12, 33, 96, DateTimeKind.Local).AddTicks(1178), 30, new DateTime(2019, 4, 8, 19, 12, 33, 96, DateTimeKind.Local).AddTicks(1185) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 8, "occaecati", new DateTime(2019, 4, 8, 19, 12, 33, 96, DateTimeKind.Local).AddTicks(1260), 38, new DateTime(2019, 4, 8, 19, 12, 33, 96, DateTimeKind.Local).AddTicks(1267) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 17, "amet", new DateTime(2019, 4, 8, 19, 12, 33, 96, DateTimeKind.Local).AddTicks(1306), 40, new DateTime(2019, 4, 8, 19, 12, 33, 96, DateTimeKind.Local).AddTicks(1312) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, "tempore", new DateTime(2019, 4, 8, 19, 12, 33, 96, DateTimeKind.Local).AddTicks(1350), 21, new DateTime(2019, 4, 8, 19, 12, 33, 96, DateTimeKind.Local).AddTicks(1356) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 16, "Molestiae ipsum commodi iste voluptates sint blanditiis. Temporibus velit rerum itaque. In est aut ut. Cum tempore et placeat ea officiis et.", new DateTime(2019, 4, 8, 19, 12, 33, 96, DateTimeKind.Local).AddTicks(1489), 29, new DateTime(2019, 4, 8, 19, 12, 33, 96, DateTimeKind.Local).AddTicks(1496) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 7, "eaque", new DateTime(2019, 4, 8, 19, 12, 33, 96, DateTimeKind.Local).AddTicks(1535), 24, new DateTime(2019, 4, 8, 19, 12, 33, 96, DateTimeKind.Local).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 20, "Quas nulla et facere et error autem autem ut.", new DateTime(2019, 4, 8, 19, 12, 33, 96, DateTimeKind.Local).AddTicks(1839), 22, new DateTime(2019, 4, 8, 19, 12, 33, 96, DateTimeKind.Local).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 10, @"Ut eum error qui aliquid velit facere quod soluta.
Corrupti possimus dolores voluptas enim magni deserunt aut voluptatem.
Cum qui repellat.", new DateTime(2019, 4, 8, 19, 12, 33, 96, DateTimeKind.Local).AddTicks(1984), 28, new DateTime(2019, 4, 8, 19, 12, 33, 96, DateTimeKind.Local).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 8, "Occaecati expedita dignissimos nisi omnis quidem sint quibusdam voluptatum illo. Quia veritatis omnis dolorem rerum ut cum quasi laborum occaecati. Et vero numquam consequuntur. Quas iure quia.", new DateTime(2019, 4, 8, 19, 12, 33, 96, DateTimeKind.Local).AddTicks(2198), 34, new DateTime(2019, 4, 8, 19, 12, 33, 96, DateTimeKind.Local).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 1, "Voluptatem quia qui sed. Dolore voluptatum expedita sed ratione adipisci inventore sint error. Sunt autem et. Ea corporis sequi officia magni molestiae sed aut. Ut vel culpa modi consectetur ut. Natus quia rem non.", new DateTime(2019, 4, 8, 19, 12, 33, 96, DateTimeKind.Local).AddTicks(2459), 28, new DateTime(2019, 4, 8, 19, 12, 33, 96, DateTimeKind.Local).AddTicks(2468) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 16, new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(770), "Fabian_Toy@hotmail.com", "GYyTTa2r", new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(1722), "Markus.Tillman" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 6, new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(2888), "Shaylee.Leffler@gmail.com", "cEzWQLbI", new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(2905), "Retha.Ondricka" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 8, new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(3071), "Rubye_Gerlach@yahoo.com", "xhq4i1nK", new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(3079), "Cleora95" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 2, new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(3293), "Gust16@hotmail.com", "eYkARLw_", new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(3302), "Bennie.Bernhard69" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 16, new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(3441), "Mina.Blanda@hotmail.com", "6c5MADXM", new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(3449), "Rebeca.Dickens" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 2, new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(3617), "Diamond69@hotmail.com", "7QgNa1ho", new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(3625), "Erwin.Wisozk75" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(3873), "Miguel16@hotmail.com", "E6gElwXt", new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(3882), "Freda30" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 4, new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(4035), "Virginia.Torp76@hotmail.com", "eYyv8Tqh", new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(4043), "Janice64" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(4227), "Ludwig_Konopelski87@gmail.com", "baqCTnDB", new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(4235), "Dolly.Bins2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 15, new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(4378), "Kattie_Gerhold69@gmail.com", "m1fq4ILv", new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(4385), "Robb.Wisoky" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(4563), "Brycen.Pfannerstill@hotmail.com", "2BQZmLR_", new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(4571), "Terrance41" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(4712), "Helene.Grimes50@hotmail.com", "cE87KcTn", new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(4720), "Raymundo17" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 13, new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(4853), "Ryan.Kirlin@hotmail.com", "D5N0_9Hk", new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(4860), "Katarina77" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 7, new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(5040), "Fleta.Keebler84@yahoo.com", "971FUpJO", new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(5048), "Elisa85" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 19, new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(5200), "Dewitt_Stoltenberg74@gmail.com", "ilOzs2x4", new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(5207), "Frederick_Bashirian29" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 12, new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(5382), "Wilburn96@gmail.com", "X4TDTQ2G", new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(5390), "Wilber70" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(5534), "Foster54@yahoo.com", "iTwl3uFN", new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(5541), "Laney.Maggio21" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 13, new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(6063), "Ken.OReilly@hotmail.com", "UOeYHTQe", new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(6075), "Herbert_Carter" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 1, new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(6265), "Dorris.Mohr@yahoo.com", "NHdxNogJ", new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(6274), "Kyleigh.Howe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 6, new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(6540), "Oswald_Cruickshank@gmail.com", "7sqY5Kz9", new DateTime(2019, 4, 8, 19, 12, 33, 84, DateTimeKind.Local).AddTicks(6550), "David.Keeling" });
        }
    }
}
