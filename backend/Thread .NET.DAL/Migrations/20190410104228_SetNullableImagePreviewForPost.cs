using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Thread_.NET.DAL.Migrations
{
    public partial class SetNullableImagePreviewForPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PreviewId",
                table: "Posts",
                nullable: true,
                oldClrType: typeof(int));

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
                columns: new[] { "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1385), new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1390), 13 });

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
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 12, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1443), new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1448), 4 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 5, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1476), true, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1481), 20 });

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
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt" },
                values: new object[] { 16, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1534), true, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1538) });

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
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 20, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1646), false, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1651), 9 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 2, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1678), false, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1682), 12 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 7, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1707), true, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1711), 18 });

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
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 4, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1763), new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1768), 9 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 4, new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1791), new DateTime(2019, 4, 10, 13, 42, 27, 540, DateTimeKind.Local).AddTicks(1796), 15 });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 17, "Illum et neque facilis.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3483), 14, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3498) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { "Ullam magnam quis nemo eum dolor quaerat eum.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3603), 10, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3610) });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 16, "Rerum iure libero voluptatem.", new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3983), 11, new DateTime(2019, 4, 10, 13, 42, 27, 524, DateTimeKind.Local).AddTicks(3990) });

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
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(928), "https://s3.amazonaws.com/uifaces/faces/twitter/rtgibbons/128.jpg", new DateTime(2019, 4, 10, 13, 42, 27, 289, DateTimeKind.Local).AddTicks(933) });

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
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4462), true, 1, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4478), 4 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4526), true, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4531), 17 });

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
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4592), false, 11, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4597), 19 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4624), false, 17, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4628), 11 });

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
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4715), 13, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4720), 15 });

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
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4873), false, 6, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4878), 6 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4904), true, 4, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4909), 1 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4933), false, 18, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(4938), 10 });

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
                columns: new[] { "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(5021), new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(5026), 13 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(5049), true, new DateTime(2019, 4, 10, 13, 42, 27, 533, DateTimeKind.Local).AddTicks(5054), 20 });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, "Rem aspernatur excepturi et.", new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(7754), 27, new DateTime(2019, 4, 10, 13, 42, 27, 516, DateTimeKind.Local).AddTicks(7761) });

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
                columns: new[] { "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { @"Minus ex odio aliquid molestiae.
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
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 15, new DateTime(2019, 4, 10, 13, 42, 27, 362, DateTimeKind.Local).AddTicks(6332), "Noel37@gmail.com", "Ov/w2Ir6JjrZM+lrZWDJZQdRTyrjeX3kkEV1sNq5DLM=", "81E5KuSfD6Wy6OFVRVrzJi2uxOmPDeOHy31ZANgLikw=", new DateTime(2019, 4, 10, 13, 42, 27, 362, DateTimeKind.Local).AddTicks(6356), "Trevion.Konopelski" });

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
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2019, 4, 10, 13, 42, 27, 430, DateTimeKind.Local).AddTicks(2390), "Finn84@gmail.com", "izsFaOQN3vHcHSvx8GGNmww7cWdIFOMBLISdizTYcw8=", "QwJmN2g2pIq3vU+epDXifJpLcfBOM84mE8O97MdJkzg=", new DateTime(2019, 4, 10, 13, 42, 27, 430, DateTimeKind.Local).AddTicks(2408), "Claudie_Von90" });

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
                columns: new[] { "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2019, 4, 10, 13, 42, 27, 460, DateTimeKind.Local).AddTicks(40), "Dane_Toy25@hotmail.com", "5ksghg+QRIoR4HCwib/D71e6GWEgIzgvHUy+/jIU8u4=", "YHCWI8ogFKXeVnbDjONhQnBcwOv9KTCv65i5aPHgxy4=", new DateTime(2019, 4, 10, 13, 42, 27, 460, DateTimeKind.Local).AddTicks(52), "Lyric_Powlowski" });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PreviewId",
                table: "Posts",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

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
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 10, new DateTime(2019, 4, 9, 13, 24, 15, 375, DateTimeKind.Local).AddTicks(9915), true, new DateTime(2019, 4, 9, 13, 24, 15, 375, DateTimeKind.Local).AddTicks(9929), 2 });

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
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 20, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(40), false, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(45), 1 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(74), new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(79), 7 });

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
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 9, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(136), new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(142), 20 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 1, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(184), false, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(191), 17 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 8, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(221), new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(226), 10 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt" },
                values: new object[] { 17, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(252), false, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(258) });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 5, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(284), new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(289), 20 });

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
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 17, new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(488), new DateTime(2019, 4, 9, 13, 24, 15, 376, DateTimeKind.Local).AddTicks(494), 11 });

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
                columns: new[] { "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { "Ab nostrum et eveniet nostrum molestias numquam quos aut nisi.", new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(2675), 15, new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(2682) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 17, "Adipisci et velit animi fugiat optio quos nesciunt.", new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(2763), 15, new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(2770) });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 7, "Consequatur excepturi ratione vel id.", new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(3249), 20, new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 14, "Possimus autem nisi.", new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(3306), 4, new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(3312) });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 16, "Aut veritatis quod fuga exercitationem maxime deserunt sapiente.", new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(3512), 5, new DateTime(2019, 4, 9, 13, 24, 15, 361, DateTimeKind.Local).AddTicks(3519) });

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
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(5394), false, 11, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(6327), 7 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7394), false, 18, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7410), 1 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7459), false, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7464), 6 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7549), false, 11, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7556), 19 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7588), true, 2, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7594), 14 });

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
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7661), 20, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7666), 10 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7693), true, 16, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7698), 20 });

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
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7757), 15, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7763), 7 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7790), false, 17, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7795), 9 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7822), false, 6, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7828), 6 });

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
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7951), false, 11, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7957), 4 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7983), true, 15, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(7989), 7 });

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
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(8048), 17, new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(8053), 9 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(8080), new DateTime(2019, 4, 9, 13, 24, 15, 369, DateTimeKind.Local).AddTicks(8085), 19 });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 9, "iste", new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(5700), 28, new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(5707) });

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
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 4, "qui", new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(5988), new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(5995) });

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
                columns: new[] { "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { "Maxime vel nemo rem aliquid nulla.", new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(6895), 33, new DateTime(2019, 4, 9, 13, 24, 15, 354, DateTimeKind.Local).AddTicks(6902) });

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
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 2, new DateTime(2019, 4, 9, 13, 24, 15, 255, DateTimeKind.Local).AddTicks(2865), "Theresia2@yahoo.com", "KFDa5zRMbIGxH5QBR2Ol/LSW+qhG4oe3KKp6Ux/z5k8=", "0hUyEzKuN4/5Hd19lesOQ+PhITWjD6V72XfSzHyAd04=", new DateTime(2019, 4, 9, 13, 24, 15, 255, DateTimeKind.Local).AddTicks(2885), "Sibyl.Sipes61" });

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
                columns: new[] { "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 299, DateTimeKind.Local).AddTicks(6022), "Lila.Jacobs@hotmail.com", "vEshTnHfB8cZirzWL/SP6u5ivZAJNR9M9/nHeekacwA=", "bnWprq23IAKMEiC1GHkae21P+pSfByeEuC3X1YJZx5o=", new DateTime(2019, 4, 9, 13, 24, 15, 299, DateTimeKind.Local).AddTicks(6035), "Ray_Bashirian93" });

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Password", "Salt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 9, 13, 24, 15, 344, DateTimeKind.Local).AddTicks(2203), "jrhihaMkIi7TrH4Hrysf4rs3K7+cdejDTJHEOrLSkjY=", "6POKtXMcxt/8lQvYjfwHCkSKyABbToTh4TfoZzHJefA=", new DateTime(2019, 4, 9, 13, 24, 15, 344, DateTimeKind.Local).AddTicks(2203) });
        }
    }
}
