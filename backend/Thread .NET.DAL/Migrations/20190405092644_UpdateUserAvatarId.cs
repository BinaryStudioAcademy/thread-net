using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Thread_.NET.DAL.Migrations
{
    public partial class UpdateUserAvatarId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Images_AvatarId",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "AvatarId",
                table: "Users",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2019, 4, 5, 12, 26, 44, 417, DateTimeKind.Local).AddTicks(9892), new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(876) });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 18, new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(1961), true, new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2065), 8 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 6, new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2106), true, new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2113), 1 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 1, new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2140), new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2145), 4 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2171), false, new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 5, new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2201), new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2206), 16 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 11, new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2229), new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2233), 4 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 14, new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2257), new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2262), 11 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2286), false, new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2290), 5 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 10, new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2315), new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2319), 3 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 13, new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2343), new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2348), 18 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 17, new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2377), true, new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2382), 12 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 19, new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2406), new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2411), 2 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 1, new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2434), true, new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2439), 15 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 15, new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2462), new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2467), 8 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 3, new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2560), new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2566), 10 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 15, new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2594), true, new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2600), 10 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 14, new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2623), false, new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2628), 1 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 6, new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2651), new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2656), 5 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2687), true, new DateTime(2019, 4, 5, 12, 26, 44, 418, DateTimeKind.Local).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 18, "Consectetur enim aut quisquam velit quas in repellendus veritatis.", new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(1212), 5, new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 6, "Sit dolor aut.", new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(3146), 7, new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(3165) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 11, "Soluta quasi quas dolorum magni quod id fugiat.", new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(3261), 19, new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 4, "Quia blanditiis consectetur qui qui voluptates excepturi quisquam error.", new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(3469), 5, new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(3479) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 16, "Non mollitia vitae voluptatibus sit ea cupiditate ea veniam.", new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(3568), 10, new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(3575) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 18, "Illum nostrum similique eos enim voluptatibus consequatur consequatur cum itaque.", new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(3653), 9, new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 6, "Distinctio officiis officiis.", new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(3712), 12, new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(3719) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 20, "Blanditiis qui quaerat in voluptatem quae omnis iste molestiae.", new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(3787), 10, new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(3794) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 9, "Reprehenderit maiores enim harum at laboriosam autem.", new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(3914), 12, new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(3923) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 3, "Modi dolores doloribus impedit expedita non occaecati provident est.", new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(4002), 15, new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(4008) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 15, "Aut totam iste.", new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(4058), 11, new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(4064) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 1, "Molestias molestiae itaque.", new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(4114), 4, new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(4121) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 11, "Et odio omnis accusantium voluptatem.", new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(4180), 19, new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(4187) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 3, "Amet facilis incidunt.", new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(4237), 12, new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 8, "Iure eum aperiam eveniet sit.", new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(4340), 17, new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 19, "Reiciendis et beatae eos autem veniam.", new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(4422), 4, new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(4429) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 13, "Adipisci tenetur et quia eius voluptatem dolores molestias aut velit.", new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(4501), 17, new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(4508) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 14, "Labore molestiae consequuntur tempora cumque.", new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(4566), 8, new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(4573) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { "Optio et provident.", new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(4620), 10, new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 3, "Hic aut quod harum neque eaque voluptas aperiam quia ut.", new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(4695), 4, new DateTime(2019, 4, 5, 12, 26, 44, 399, DateTimeKind.Local).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 350, DateTimeKind.Local).AddTicks(7699), "https://s3.amazonaws.com/uifaces/faces/twitter/laurengray/128.jpg", new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(4527) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7283), "https://s3.amazonaws.com/uifaces/faces/twitter/jcubic/128.jpg", new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7351), "https://s3.amazonaws.com/uifaces/faces/twitter/mrxloka/128.jpg", new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7359) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7383), "https://s3.amazonaws.com/uifaces/faces/twitter/elisabethkjaer/128.jpg", new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7388) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7409), "https://s3.amazonaws.com/uifaces/faces/twitter/vikasvinfotech/128.jpg", new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7414) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7435), "https://s3.amazonaws.com/uifaces/faces/twitter/swooshycueb/128.jpg", new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7460), "https://s3.amazonaws.com/uifaces/faces/twitter/al_li/128.jpg", new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7484), "https://s3.amazonaws.com/uifaces/faces/twitter/naupintos/128.jpg", new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7511), "https://s3.amazonaws.com/uifaces/faces/twitter/thiagovernetti/128.jpg", new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7536), "https://s3.amazonaws.com/uifaces/faces/twitter/joemdesign/128.jpg", new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7649), "https://s3.amazonaws.com/uifaces/faces/twitter/waghner/128.jpg", new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7656) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7685), "https://s3.amazonaws.com/uifaces/faces/twitter/syropian/128.jpg", new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7712), "https://s3.amazonaws.com/uifaces/faces/twitter/skkirilov/128.jpg", new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7737), "https://s3.amazonaws.com/uifaces/faces/twitter/joeymurdah/128.jpg", new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7742) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7762), "https://s3.amazonaws.com/uifaces/faces/twitter/devankoshal/128.jpg", new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7788), "https://s3.amazonaws.com/uifaces/faces/twitter/netonet_il/128.jpg", new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7813), "https://s3.amazonaws.com/uifaces/faces/twitter/foczzi/128.jpg", new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7837), "https://s3.amazonaws.com/uifaces/faces/twitter/edobene/128.jpg", new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7861), "https://s3.amazonaws.com/uifaces/faces/twitter/megdraws/128.jpg", new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7866) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7887), "https://s3.amazonaws.com/uifaces/faces/twitter/carlfairclough/128.jpg", new DateTime(2019, 4, 5, 12, 26, 44, 354, DateTimeKind.Local).AddTicks(7892) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(7774), "https://picsum.photos/640/480/?image=434", new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9007), "https://picsum.photos/640/480/?image=224", new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9023) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9052), "https://picsum.photos/640/480/?image=329", new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9057) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9078), "https://picsum.photos/640/480/?image=513", new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9083) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9104), "https://picsum.photos/640/480/?image=1043", new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9109) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9129), "https://picsum.photos/640/480/?image=763", new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9134) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9154), "https://picsum.photos/640/480/?image=695", new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9158) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9223), "https://picsum.photos/640/480/?image=675", new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9257), "https://picsum.photos/640/480/?image=851", new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9262) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9282), "https://picsum.photos/640/480/?image=950", new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9287) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9306), "https://picsum.photos/640/480/?image=737", new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9331), "https://picsum.photos/640/480/?image=76", new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9355), "https://picsum.photos/640/480/?image=393", new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9380), "https://picsum.photos/640/480/?image=883", new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9385) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9405), "https://picsum.photos/640/480/?image=371", new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9429), "https://picsum.photos/640/480/?image=590", new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9433) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9453), "https://picsum.photos/640/480/?image=481", new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9476), "https://picsum.photos/640/480/?image=969", new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9500), "https://picsum.photos/640/480/?image=94", new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9505) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9524), "https://picsum.photos/640/480/?image=987", new DateTime(2019, 4, 5, 12, 26, 44, 360, DateTimeKind.Local).AddTicks(9528) });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 409, DateTimeKind.Local).AddTicks(9321), false, 8, new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(313), 11 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1161), 5, new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1180), 4 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1220), 12, new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1227), 13 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1254), false, 12, new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1260), 1 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1286), 16, new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1291), 6 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1315), 4, new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1320), 10 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1343), true, 16, new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1349), 2 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1425), true, 13, new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1431), 11 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1462), true, 10, new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1468), 12 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1491), 5, new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1497), 12 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1521), 3, new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1526), 4 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1551), false, 18, new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1556), 20 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1579), false, 13, new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1584), 10 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1607), 18, new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1612), 12 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1635), true, 18, new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1640), 6 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1664), 19, new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1669), 1 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1825), true, 11, new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1833), 19 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1894), true, 1, new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1901), 18 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1928), 20, new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1933), 11 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1956), 13, new DateTime(2019, 4, 5, 12, 26, 44, 410, DateTimeKind.Local).AddTicks(1962), 18 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { "suscipit", new DateTime(2019, 4, 5, 12, 26, 44, 387, DateTimeKind.Local).AddTicks(8095), 34, new DateTime(2019, 4, 5, 12, 26, 44, 387, DateTimeKind.Local).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 10, "Consectetur libero assumenda sit laborum dignissimos nobis cumque. Quaerat eius quam esse omnis architecto sed asperiores nam voluptatem. Dolorem optio ut ex voluptates. Et enim ratione ut voluptates exercitationem.", new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(818), 35, new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(844) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 16, "natus", new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(938), 23, new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(945) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 20, "Praesentium non sapiente iusto quis provident ut.", new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(3121), 38, new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 9, "Rerum aspernatur atque dolores. Velit aut velit sed esse omnis et ut molestiae. Sint nisi sint ea velit adipisci quos at. Minus totam voluptatibus vel. Perferendis corporis ut natus.", new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(3601), 36, new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(3612) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 10, @"Autem porro nobis ut repellat quae vel ut.
Ducimus voluptas aliquid.", new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(5140), 32, new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(5154) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 2, "Sapiente qui dolore magnam voluptas ullam et.", new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(5314), 35, new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(5323) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 11, @"Inventore deserunt sint veritatis.
Harum quisquam nobis sint non dolores consequatur at iure vel.", new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(5438), 31, new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 5, "Hic illo autem perferendis eum voluptas rerum dolores quis. Non rem recusandae quia quis dolores recusandae dolor ducimus sint. Impedit doloribus aperiam ut odio qui vel et. Amet voluptatem veritatis aliquam aliquam alias quibusdam et cum eos.", new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(5674), 34, new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(5681) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 7, "Quisquam voluptatem officiis cum aspernatur aut animi.", new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(5747), 36, new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 14, @"Veritatis omnis fugit rerum.
Error sunt iure assumenda rerum.", new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(5835), 29, new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(5842) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 1, "Iusto aut nemo tempora quas enim et enim. Error quisquam veniam ipsa ullam molestiae sint sint magni perferendis. Eaque eum minus est consequuntur et aut autem est est. Facere consequatur sit dolorem.", new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(6096), 34, new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(6105) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 2, "Non harum ducimus ut vel est veniam.", new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(6173), 31, new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(6180) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 14, "Eveniet unde voluptates.", new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(6289), 28, new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(6298) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 3, "consequatur", new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(6336), 31, new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(6342) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 1, "Ut enim quis delectus rem eos magni assumenda. Adipisci excepturi vitae corporis deserunt voluptatem ex consequuntur nulla sed. Qui quod impedit est nulla praesentium occaecati fugit exercitationem molestias. Voluptas harum asperiores et.", new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(6529), 40, new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(6537) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 1, @"A sunt sequi nihil aperiam eum quae quasi.
Aut voluptate aliquam id vel amet quibusdam natus est quia.
Laboriosam sit rem.
Aut placeat qui enim nobis.
Ut dignissimos aperiam dignissimos.
Aut officia consequatur laborum perferendis velit qui eius veniam aspernatur.", new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(6814), 40, new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 6, "Aut ea veniam natus autem suscipit earum aspernatur repellendus.", new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(6903), 35, new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 12, "Eum quo distinctio delectus modi nostrum quam nemo.", new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(6972), 25, new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, "odit", new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(7014), 33, new DateTime(2019, 4, 5, 12, 26, 44, 390, DateTimeKind.Local).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 17, new DateTime(2019, 4, 5, 12, 26, 44, 377, DateTimeKind.Local).AddTicks(6138), "Keanu26@yahoo.com", "gtKIM38N", new DateTime(2019, 4, 5, 12, 26, 44, 377, DateTimeKind.Local).AddTicks(7208), "Derick_Brekke" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 18, new DateTime(2019, 4, 5, 12, 26, 44, 377, DateTimeKind.Local).AddTicks(8541), "Tristian_Fisher19@gmail.com", "QBrA9oWF", new DateTime(2019, 4, 5, 12, 26, 44, 377, DateTimeKind.Local).AddTicks(8562), "Eldred65" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2019, 4, 5, 12, 26, 44, 377, DateTimeKind.Local).AddTicks(8802), "Therese28@yahoo.com", "zk4Kio0f", new DateTime(2019, 4, 5, 12, 26, 44, 377, DateTimeKind.Local).AddTicks(8811), "Ernest.Hermiston79" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 17, new DateTime(2019, 4, 5, 12, 26, 44, 377, DateTimeKind.Local).AddTicks(8960), "Garrick.Pacocha@gmail.com", "Hxaw2l6G", new DateTime(2019, 4, 5, 12, 26, 44, 377, DateTimeKind.Local).AddTicks(8968), "Shawn17" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 11, new DateTime(2019, 4, 5, 12, 26, 44, 377, DateTimeKind.Local).AddTicks(9094), "Rachel_Turcotte@hotmail.com", "3Z7VPggZ", new DateTime(2019, 4, 5, 12, 26, 44, 377, DateTimeKind.Local).AddTicks(9101), "Shea83" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 15, new DateTime(2019, 4, 5, 12, 26, 44, 377, DateTimeKind.Local).AddTicks(9282), "Lloyd83@hotmail.com", "O9EXrQre", new DateTime(2019, 4, 5, 12, 26, 44, 377, DateTimeKind.Local).AddTicks(9290), "Lilliana_Hettinger52" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 3, new DateTime(2019, 4, 5, 12, 26, 44, 377, DateTimeKind.Local).AddTicks(9426), "Chauncey_Gutkowski@gmail.com", "1QRw0BRq", new DateTime(2019, 4, 5, 12, 26, 44, 377, DateTimeKind.Local).AddTicks(9433), "Ara_Thompson11" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 17, new DateTime(2019, 4, 5, 12, 26, 44, 378, DateTimeKind.Local).AddTicks(56), "Louisa74@gmail.com", "gJvGhsCt", new DateTime(2019, 4, 5, 12, 26, 44, 378, DateTimeKind.Local).AddTicks(68), "Berenice25" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 378, DateTimeKind.Local).AddTicks(239), "Carolyn_Harris96@hotmail.com", "jGCstIuy", new DateTime(2019, 4, 5, 12, 26, 44, 378, DateTimeKind.Local).AddTicks(247), "Haleigh67" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2019, 4, 5, 12, 26, 44, 378, DateTimeKind.Local).AddTicks(429), "Israel77@gmail.com", "NoHgGMSf", new DateTime(2019, 4, 5, 12, 26, 44, 378, DateTimeKind.Local).AddTicks(437), "Colleen39" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 10, new DateTime(2019, 4, 5, 12, 26, 44, 378, DateTimeKind.Local).AddTicks(562), "Jacey_Ullrich@yahoo.com", "D_V4j2fc", new DateTime(2019, 4, 5, 12, 26, 44, 378, DateTimeKind.Local).AddTicks(569), "Kim_Green" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 19, new DateTime(2019, 4, 5, 12, 26, 44, 378, DateTimeKind.Local).AddTicks(733), "Richie14@yahoo.com", "WXsDRvh6", new DateTime(2019, 4, 5, 12, 26, 44, 378, DateTimeKind.Local).AddTicks(741), "Sanford_Hahn" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 16, new DateTime(2019, 4, 5, 12, 26, 44, 378, DateTimeKind.Local).AddTicks(874), "Reid_Kub@yahoo.com", "4for4aIJ", new DateTime(2019, 4, 5, 12, 26, 44, 378, DateTimeKind.Local).AddTicks(882), "Richmond55" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 18, new DateTime(2019, 4, 5, 12, 26, 44, 378, DateTimeKind.Local).AddTicks(1054), "Mark.Schowalter50@gmail.com", "l_l3nIBC", new DateTime(2019, 4, 5, 12, 26, 44, 378, DateTimeKind.Local).AddTicks(1063), "Rey78" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 2, new DateTime(2019, 4, 5, 12, 26, 44, 378, DateTimeKind.Local).AddTicks(1197), "Dana47@hotmail.com", "DjKxoj7T", new DateTime(2019, 4, 5, 12, 26, 44, 378, DateTimeKind.Local).AddTicks(1205), "Dylan.Frami" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 11, new DateTime(2019, 4, 5, 12, 26, 44, 378, DateTimeKind.Local).AddTicks(1460), "Ashleigh.Pagac@gmail.com", "S7SIRUkO", new DateTime(2019, 4, 5, 12, 26, 44, 378, DateTimeKind.Local).AddTicks(1470), "Halie81" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 3, new DateTime(2019, 4, 5, 12, 26, 44, 378, DateTimeKind.Local).AddTicks(1712), "Vidal_Hilll@gmail.com", "7LXNZaji", new DateTime(2019, 4, 5, 12, 26, 44, 378, DateTimeKind.Local).AddTicks(1720), "Odie.McLaughlin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2019, 4, 5, 12, 26, 44, 378, DateTimeKind.Local).AddTicks(1855), "Glenda_Heathcote56@gmail.com", "vrJf9dsc", new DateTime(2019, 4, 5, 12, 26, 44, 378, DateTimeKind.Local).AddTicks(1862), "Randall.Prosacco50" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 2, new DateTime(2019, 4, 5, 12, 26, 44, 378, DateTimeKind.Local).AddTicks(2131), "Kennedy43@yahoo.com", "lfKkSXzq", new DateTime(2019, 4, 5, 12, 26, 44, 378, DateTimeKind.Local).AddTicks(2139), "Zack_Davis42" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2019, 4, 5, 12, 26, 44, 378, DateTimeKind.Local).AddTicks(2269), "Concepcion39@hotmail.com", "5umpaXza", new DateTime(2019, 4, 5, 12, 26, 44, 378, DateTimeKind.Local).AddTicks(2276), "Felicity_Hagenes" });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Images_AvatarId",
                table: "Users",
                column: "AvatarId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Images_AvatarId",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "AvatarId",
                table: "Users",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt" },
                values: new object[] { 14, new DateTime(2019, 4, 2, 18, 8, 29, 914, DateTimeKind.Local).AddTicks(4119), new DateTime(2019, 4, 2, 18, 8, 29, 914, DateTimeKind.Local).AddTicks(4119) });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 12, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1498), false, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1498), 1 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 2, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1647), false, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1647), 10 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 18, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1679), new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1679), 10 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt" },
                values: new object[] { 16, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1703), true, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 15, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1724), new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1724), 7 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 2, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1799), new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1799), 11 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 16, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1823), new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1823), 7 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1844), true, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1844), 8 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 1, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1867), new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1867), 7 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 12, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1909), new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1909), 4 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 16, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1983), false, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1983), 8 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 11, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(2007), new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(2007), 15 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 20, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(2029), false, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(2029), 11 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 18, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(2051), new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(2051), 18 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 16, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(2073), new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(2073), 16 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 3, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(2093), false, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(2093), 8 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[] { 17, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(2114), true, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(2114), 5 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CommentId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 10, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(2135), new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(2135), 19 });

            migrationBuilder.UpdateData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CommentId", "CreatedAt", "IsLike", "UpdatedAt" },
                values: new object[] { 13, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(2156), false, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 19, "Fuga qui aut qui vel et dolores pariatur eos.", new DateTime(2019, 4, 2, 18, 8, 29, 898, DateTimeKind.Local).AddTicks(4923), 13, new DateTime(2019, 4, 2, 18, 8, 29, 898, DateTimeKind.Local).AddTicks(4923) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 15, "Quia dolores et.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(5459), 9, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(5459) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 19, "Excepturi reiciendis quidem aut.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(5680), 10, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 6, "Rerum non eos voluptatem omnis impedit perspiciatis.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(5744), 10, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(5744) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 1, "Natus delectus hic.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(5808), 14, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(5808) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 17, "Eaque fuga ut modi explicabo laudantium eligendi quam error commodi.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(5860), 19, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 5, "Consequuntur occaecati tempora et tempora iusto reprehenderit repellat officia nemo.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(5938), 2, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 10, "Est autem labore facere rem sequi nulla sit animi.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6071), 13, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 4, "Velit deleniti quo quisquam cumque.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6144), 18, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6144) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 6, "Quia ex animi suscipit ut est officia.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6197), 20, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6197) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 4, "Ipsam ab nesciunt magnam id ipsam.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6252), 17, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 6, "Soluta dicta sint cupiditate ipsa in aliquid vel tenetur iste.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6303), 18, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 8, "Nisi qui occaecati.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6427), 16, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6427) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 15, "Ea maxime error similique inventore voluptatem neque animi odit neque.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6479), 11, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6479) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 16, "Necessitatibus ullam consectetur cupiditate ea fugiat iste.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6549), 20, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 6, "Quidem quisquam soluta natus adipisci impedit impedit qui consequatur ut.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6604), 9, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6604) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 18, "Fugit occaecati eos quis.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6664), 20, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6664) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 20, "Et non eaque id.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6708), 17, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6708) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { "Molestiae fugit sed eius.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6808), 9, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6808) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 20, "Non pariatur autem deserunt delectus necessitatibus qui et autem.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6859), 6, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6859) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 851, DateTimeKind.Local).AddTicks(8476), "https://s3.amazonaws.com/uifaces/faces/twitter/g3d/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 851, DateTimeKind.Local).AddTicks(8476) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3449), "https://s3.amazonaws.com/uifaces/faces/twitter/johnsmithagency/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3638), "https://s3.amazonaws.com/uifaces/faces/twitter/hiemil/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3638) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3667), "https://s3.amazonaws.com/uifaces/faces/twitter/shesgared/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3667) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3686), "https://s3.amazonaws.com/uifaces/faces/twitter/uxpiper/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3686) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3703), "https://s3.amazonaws.com/uifaces/faces/twitter/anatolinicolae/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3703) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3721), "https://s3.amazonaws.com/uifaces/faces/twitter/borantula/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3721) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3737), "https://s3.amazonaws.com/uifaces/faces/twitter/jeremyshimko/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3737) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3754), "https://s3.amazonaws.com/uifaces/faces/twitter/geshan/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3770), "https://s3.amazonaws.com/uifaces/faces/twitter/devankoshal/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3786), "https://s3.amazonaws.com/uifaces/faces/twitter/mattlat/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3801), "https://s3.amazonaws.com/uifaces/faces/twitter/codysanfilippo/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3801) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3817), "https://s3.amazonaws.com/uifaces/faces/twitter/jonathansimmons/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3833), "https://s3.amazonaws.com/uifaces/faces/twitter/iqbalperkasa/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3833) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3848), "https://s3.amazonaws.com/uifaces/faces/twitter/jcubic/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3848) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3867), "https://s3.amazonaws.com/uifaces/faces/twitter/zauerkraut/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3867) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3882), "https://s3.amazonaws.com/uifaces/faces/twitter/syropian/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3897), "https://s3.amazonaws.com/uifaces/faces/twitter/plasticine/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3897) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3912), "https://s3.amazonaws.com/uifaces/faces/twitter/teylorfeliz/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3912) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3926), "https://s3.amazonaws.com/uifaces/faces/twitter/kolsvein/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3926) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 868, DateTimeKind.Local).AddTicks(3159), "https://picsum.photos/640/480/?image=104", new DateTime(2019, 4, 2, 18, 8, 29, 868, DateTimeKind.Local).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3438), "https://picsum.photos/640/480/?image=497", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3438) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3511), "https://picsum.photos/640/480/?image=563", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3531), "https://picsum.photos/640/480/?image=478", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3548), "https://picsum.photos/640/480/?image=740", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3548) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3565), "https://picsum.photos/640/480/?image=771", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3565) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3581), "https://picsum.photos/640/480/?image=277", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3581) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3658), "https://picsum.photos/640/480/?image=1081", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3658) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3680), "https://picsum.photos/640/480/?image=1060", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3697), "https://picsum.photos/640/480/?image=404", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3697) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3714), "https://picsum.photos/640/480/?image=1017", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3714) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3730), "https://picsum.photos/640/480/?image=583", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3730) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3745), "https://picsum.photos/640/480/?image=402", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3745) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3761), "https://picsum.photos/640/480/?image=613", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3761) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3776), "https://picsum.photos/640/480/?image=392", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3776) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3792), "https://picsum.photos/640/480/?image=109", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3792) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3808), "https://picsum.photos/640/480/?image=727", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3808) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3823), "https://picsum.photos/640/480/?image=498", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3823) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3838), "https://picsum.photos/640/480/?image=946", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3854), "https://picsum.photos/640/480/?image=708", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3854) });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 906, DateTimeKind.Local).AddTicks(5856), true, 2, new DateTime(2019, 4, 2, 18, 8, 29, 906, DateTimeKind.Local).AddTicks(5856), 4 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1179), 10, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1179), 11 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1336), 16, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1336), 16 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1367), true, 14, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1367), 9 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1390), 8, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1390), 12 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1411), 13, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1411), 16 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1430), false, 3, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1430), 7 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1452), false, 4, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1452), 7 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1472), false, 16, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1472), 10 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1492), 17, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1492), 2 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1513), 2, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1513), 17 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1533), true, 14, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1533), 11 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1552), true, 12, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1552), 19 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1576), 8, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1576), 11 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1595), false, 11, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1595), 12 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1615), 1, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1615), 9 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1659), false, 13, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1659), 7 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1738), false, 14, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1738), 11 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1761), 17, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1761), 10 });

            migrationBuilder.UpdateData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1781), 2, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1781), 7 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { @"Hic eos omnis consequatur.
Quo saepe natus quidem.
Deserunt ipsa sapiente ut optio aut rem molestiae eos eius.", new DateTime(2019, 4, 2, 18, 8, 29, 888, DateTimeKind.Local).AddTicks(8294), 30, new DateTime(2019, 4, 2, 18, 8, 29, 888, DateTimeKind.Local).AddTicks(8294) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, "velit", new DateTime(2019, 4, 2, 18, 8, 29, 891, DateTimeKind.Local).AddTicks(9946), 39, new DateTime(2019, 4, 2, 18, 8, 29, 891, DateTimeKind.Local).AddTicks(9946) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 1, @"Excepturi a nesciunt recusandae corrupti quis odio voluptatum minima quae.
Deleniti fugit voluptatem facere aut sit.
Et ea aliquid molestiae id.", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(689), 38, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(689) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 11, "Aliquid rerum ea dolorem expedita id consequuntur a. Odit voluptatum soluta quaerat et consectetur. Ducimus quod consequatur perspiciatis voluptatum odio.", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(1010), 39, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 2, "debitis", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(3936), 33, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(3936) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 14, "Sint qui qui aut quia.", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(4006), 28, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(4006) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 3, "qui", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(5676), 31, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(5676) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 7, "Et qui aut pariatur ut tempora velit ad reprehenderit animi. Voluptates reiciendis qui repellat. Alias ipsa est dolores consectetur maxime sed qui autem. Optio quia et vero ea cum eveniet asperiores cum. Omnis facere pariatur consequuntur aut.", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(5723), 33, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 17, @"Esse eos dolore quae.
Aspernatur consectetur voluptate quisquam sed veniam est.
Odio non quia ex provident velit.
Perferendis voluptatibus qui facilis alias dolore.
Deleniti magnam perspiciatis voluptate.", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(6021), 40, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(6021) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 20, "vel", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(6496), 37, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(6496) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 17, "Corrupti quos ad natus quasi. Minima voluptate mollitia cum. Aut nisi dolorem velit et. Animi ipsa quaerat et impedit sequi quia impedit.", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(6536), 26, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, "Eligendi dolore deleniti.", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(6781), 24, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 4, "Qui in officiis ut repellendus aut in aliquam. Et rerum sapiente rerum fugit ea fugiat. In dolor suscipit. Pariatur repellendus quis. Ut et et consequatur dolorum qui ipsum soluta est dolores.", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(6858), 21, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 13, "Dolorem culpa et.", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(7082), 23, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(7082) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 12, "aliquid", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(7132), 23, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 7, "Quos non sit. Id autem qui consequatur iusto reiciendis ratione. Voluptatibus sed totam veniam modi voluptatibus. Distinctio aut minima a possimus. Quod voluptatem sunt laborum.", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(7162), 25, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(7162) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 15, @"A sapiente dolores fugit in incidunt officia.
Est nulla iusto voluptatum consequuntur.", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(7350), 29, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 12, "saepe", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(7436), 32, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(7436) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 8, "Aliquam molestiae et asperiores. Dolores qui sed et animi minima qui et. Temporibus odit culpa aut quasi cupiditate officia. Quia cumque et.", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(7467), 35, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 19, @"Asperiores quia et maxime nihil quasi soluta ea.
Explicabo rerum atque adipisci fugiat adipisci tempore.
Modi veniam temporibus sit.", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(7641), 29, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(7641) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 12, new DateTime(2019, 4, 2, 18, 8, 29, 875, DateTimeKind.Local).AddTicks(8202), "Ena71@gmail.com", "Ykta0p3j", new DateTime(2019, 4, 2, 18, 8, 29, 875, DateTimeKind.Local).AddTicks(8202), "Jon.Hoppe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 6, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(5286), "Clyde46@hotmail.com", "kMdcqBC2", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(5286), "Lucius12" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 2, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(5899), "Travis_Orn25@yahoo.com", "rIQMu8t1", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(5899), "Eleanora74" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 13, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(6088), "Gregorio_Hettinger@hotmail.com", "qdfNRCD1", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(6088), "Sarah_Von72" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 8, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(6301), "Paul_Bosco1@yahoo.com", "oFaePi37", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(6301), "Dasia1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(6431), "Lela_Schmidt@hotmail.com", "OcY7QhHd", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(6431), "Guy_Waelchi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 1, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(6605), "Joannie.Christiansen83@yahoo.com", "ksM16tDk", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(6605), "Jeffery_Stiedemann90" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 2, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(6798), "Vicente75@yahoo.com", "6RBimjs1", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(6798), "Major_Crooks" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(6983), "Eugene82@gmail.com", "06MJIRXF", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(6983), "Oral.Harvey" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 6, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(7115), "Cullen47@yahoo.com", "gAiqI6LH", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(7115), "Christina.Prosacco96" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 5, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(7288), "Eda.Bergstrom78@gmail.com", "MFAXZThC", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(7288), "Lawrence.Corwin51" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 3, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(7425), "Marilyne8@hotmail.com", "hG35chpF", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(7425), "Astrid.Johnson" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 8, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(7602), "Ashleigh.Kunde@hotmail.com", "rR5wowmT", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(7602), "Genevieve.Mante68" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 20, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(7727), "Winona_Hagenes@gmail.com", "EcB7pQ6g", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(7727), "Aimee_Dooley7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 16, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(7844), "Shaun20@hotmail.com", "dz1r35Nk", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(7844), "Larue_Kris" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(8013), "Anna74@hotmail.com", "WkSw14l1", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(8013), "Braeden.Reichert16" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 15, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(8142), "Jared16@yahoo.com", "mAmrecut", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(8142), "Hattie67" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(8309), "Alfred_Gorczany5@yahoo.com", "RKfonEhf", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(8309), "Dannie_Macejkovic" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 3, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(8435), "Stuart68@gmail.com", "34UcXcu1", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(8435), "Helen84" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { 1, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(8630), "Celestine30@hotmail.com", "67Cu_ULu", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(8630), "Eleanora_Grady" });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Images_AvatarId",
                table: "Users",
                column: "AvatarId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
