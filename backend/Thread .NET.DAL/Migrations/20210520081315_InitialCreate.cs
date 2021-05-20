using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Thread_.NET.DAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvatarId = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Images_AvatarId",
                        column: x => x.AvatarId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    PreviewId = table.Column<int>(type: "int", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Images_PreviewId",
                        column: x => x.PreviewId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Posts_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Expires = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostReactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    IsLike = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostReactions", x => x.Id);
                    table.UniqueConstraint("AK_PostReactions_PostId_UserId", x => new { x.PostId, x.UserId });
                    table.ForeignKey(
                        name: "FK_PostReactions_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostReactions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommentReactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    IsLike = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentReactions", x => x.Id);
                    table.UniqueConstraint("AK_CommentReactions_CommentId_UserId", x => new { x.CommentId, x.UserId });
                    table.ForeignKey(
                        name: "FK_CommentReactions_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommentReactions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedAt", "URL", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(1845), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1081.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(7597) },
                    { 23, new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4108), "https://picsum.photos/640/480/?image=938", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4115) },
                    { 24, new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4141), "https://picsum.photos/640/480/?image=582", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4147) },
                    { 25, new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4167), "https://picsum.photos/640/480/?image=200", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4172) },
                    { 26, new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4192), "https://picsum.photos/640/480/?image=556", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4197) },
                    { 27, new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4217), "https://picsum.photos/640/480/?image=895", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4223) },
                    { 28, new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4243), "https://picsum.photos/640/480/?image=501", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4248) },
                    { 29, new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4268), "https://picsum.photos/640/480/?image=779", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4273) },
                    { 30, new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4292), "https://picsum.photos/640/480/?image=971", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4297) },
                    { 31, new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4316), "https://picsum.photos/640/480/?image=677", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4321) },
                    { 32, new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4340), "https://picsum.photos/640/480/?image=987", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4345) },
                    { 33, new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4365), "https://picsum.photos/640/480/?image=842", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4371) },
                    { 34, new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4390), "https://picsum.photos/640/480/?image=127", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4395) },
                    { 35, new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4415), "https://picsum.photos/640/480/?image=312", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4420) },
                    { 36, new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4480), "https://picsum.photos/640/480/?image=122", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4485) },
                    { 37, new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4509), "https://picsum.photos/640/480/?image=416", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4514) },
                    { 38, new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4534), "https://picsum.photos/640/480/?image=127", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4539) },
                    { 39, new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4558), "https://picsum.photos/640/480/?image=49", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4563) },
                    { 22, new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(3959), "https://picsum.photos/640/480/?image=210", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(3967) },
                    { 40, new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4582), "https://picsum.photos/640/480/?image=579", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4587) },
                    { 21, new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(2515), "https://picsum.photos/640/480/?image=34", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(3678) },
                    { 19, new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8810), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/885.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8815) },
                    { 2, new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8310), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/462.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8321) },
                    { 3, new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8352), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1199.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8357) },
                    { 4, new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8377), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/36.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8382) },
                    { 5, new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8401), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/488.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8406) },
                    { 6, new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8497), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/210.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8504) },
                    { 7, new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8526), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1032.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8531) },
                    { 8, new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8551), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/4.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8556) },
                    { 9, new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8574), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1002.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8579) },
                    { 10, new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8598), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/298.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8603) },
                    { 11, new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8621), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/60.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8626) },
                    { 12, new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8644), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/996.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8650) },
                    { 13, new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8669), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1043.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8674) },
                    { 14, new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8693), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/813.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8698) },
                    { 15, new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8716), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/965.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8721) },
                    { 16, new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8740), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1187.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8745) },
                    { 17, new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8763), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/443.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8768) },
                    { 18, new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8787), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/857.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8792) },
                    { 20, new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8833), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/898.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8838) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 21, null, new DateTime(2021, 5, 20, 11, 13, 15, 20, DateTimeKind.Local).AddTicks(3327), "test@gmail.com", "UGZorU7ixmt7ZHZpwbpmfxeeDK1RdaxwQ8tmD7ojIGU=", "lAdg0m8nOXEvf6zmjZ8bbXKHhE8QfSpTUcV9L09Z+84=", new DateTime(2021, 5, 20, 11, 13, 15, 20, DateTimeKind.Local).AddTicks(3327), "testUser" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 9, 21, "Dicta est reiciendis voluptas earum odit cumque in suscipit in.", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(7857), 38, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(7883) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { 19, 19, new DateTime(2021, 5, 20, 11, 13, 14, 998, DateTimeKind.Local).AddTicks(5070), "Kathryn_Abshire82@yahoo.com", "YPW+idxIGypCR3HAHfvBYxoTJIrKQqywAgAdOTCkUDQ=", "aLSTRGtEVgAXEB7SxTJVGuz2WAyBd8+WJ2DHMPCQAaQ=", new DateTime(2021, 5, 20, 11, 13, 14, 998, DateTimeKind.Local).AddTicks(5100), "Amina.Skiles4" },
                    { 3, 19, new DateTime(2021, 5, 20, 11, 13, 14, 846, DateTimeKind.Local).AddTicks(7785), "Kendrick_Emmerich13@gmail.com", "hwaghCHm2/1iUok1aCOO6BLTATiQihj5O2AH/ftjbRE=", "+uJsbanlGIkilFjT1yEIO2jLY+GJdMK/HVrxnuwP6i8=", new DateTime(2021, 5, 20, 11, 13, 14, 846, DateTimeKind.Local).AddTicks(7817), "Lenore16" },
                    { 16, 16, new DateTime(2021, 5, 20, 11, 13, 14, 970, DateTimeKind.Local).AddTicks(4430), "Chester.Gibson@yahoo.com", "VxSMljQua5wzDvMTEaHBXvqXg52XaKLJZ9FwWeAr64A=", "99Xcb7TKeygJf4WqTJHCz40J7et0ShfsSKdBaosYcIU=", new DateTime(2021, 5, 20, 11, 13, 14, 970, DateTimeKind.Local).AddTicks(4500), "Zetta_Corwin" },
                    { 10, 15, new DateTime(2021, 5, 20, 11, 13, 14, 913, DateTimeKind.Local).AddTicks(1972), "Madge.McKenzie27@hotmail.com", "wkwbVcA0aF/VIzL/IDIjM7Azl1hRLCpn60+08IGE6BU=", "0FdI7ApNn6iiqH+JugvWa51yvP0xQNkO1rRxsvQ2Dlo=", new DateTime(2021, 5, 20, 11, 13, 14, 913, DateTimeKind.Local).AddTicks(2019), "Warren_Bernier" },
                    { 18, 14, new DateTime(2021, 5, 20, 11, 13, 14, 987, DateTimeKind.Local).AddTicks(9474), "Maximus.Schowalter@hotmail.com", "07nUGFmM3kNcnN5BVOql7SjpvK++FzyfLSDhRBW5uhc=", "AlXbT32FGJzaFlNqe7BeNZHBHbEVro2VwUaHkpWOo/k=", new DateTime(2021, 5, 20, 11, 13, 14, 987, DateTimeKind.Local).AddTicks(9547), "Magnolia_Klocko" },
                    { 15, 14, new DateTime(2021, 5, 20, 11, 13, 14, 960, DateTimeKind.Local).AddTicks(4225), "Webster.Armstrong@yahoo.com", "LbmH1t3nBO0bGpMlURNDdHCbhfm4YFhBp6i8jvYW89g=", "8aLXS7QORAG4uDB+wL5UxChZxhszib/in2oWivPE3oY=", new DateTime(2021, 5, 20, 11, 13, 14, 960, DateTimeKind.Local).AddTicks(4300), "Sigurd_Koch" },
                    { 2, 13, new DateTime(2021, 5, 20, 11, 13, 14, 837, DateTimeKind.Local).AddTicks(138), "Dave79@yahoo.com", "d32nF9qsABrvxMVc32IrJVyR99sYzoFWb8KMrKJtcBo=", "tKnkVn1ZFt/SZzKzklyEc3+JSjAszT7v5RMwkfSSA6I=", new DateTime(2021, 5, 20, 11, 13, 14, 837, DateTimeKind.Local).AddTicks(212), "Al_Raynor" },
                    { 20, 10, new DateTime(2021, 5, 20, 11, 13, 15, 9, DateTimeKind.Local).AddTicks(4440), "Javon.Hane5@yahoo.com", "qjQeVb5gyvGZR7JCCa3WcNpCJbbZC1msMQAAm8xzC88=", "sOIYRCoaEv1lNThIyXb7kFDIyRELtsXhnm+bAfZ5fj0=", new DateTime(2021, 5, 20, 11, 13, 15, 9, DateTimeKind.Local).AddTicks(4506), "Precious44" },
                    { 4, 20, new DateTime(2021, 5, 20, 11, 13, 14, 856, DateTimeKind.Local).AddTicks(5118), "Lelia_Wintheiser@gmail.com", "NT0Ru66Nr2SQMOYwTg7h8HFDkbhZSGnjrOhfKMCK/VY=", "bRn9pW/8YH842PoDeaPqCJs4ZzFupb6KLJ5cFgWvvXI=", new DateTime(2021, 5, 20, 11, 13, 14, 856, DateTimeKind.Local).AddTicks(5182), "Lionel74" },
                    { 12, 10, new DateTime(2021, 5, 20, 11, 13, 14, 931, DateTimeKind.Local).AddTicks(4810), "Etha.Kuhic@hotmail.com", "tUkmuUC33oqMFIku6hXOpevaYAFHpD2+MLu02CIEfYg=", "xM96YjEgTurGXzj8FfvB3DIj8YsMlioDF0vJrWGj63c=", new DateTime(2021, 5, 20, 11, 13, 14, 931, DateTimeKind.Local).AddTicks(4874), "Antonio.Kub" },
                    { 7, 9, new DateTime(2021, 5, 20, 11, 13, 14, 885, DateTimeKind.Local).AddTicks(1450), "Kaleb27@hotmail.com", "J1uf9/PUNeKVrn7jF/Yq7m+0EwZADBlvR+cV+rtcxZQ=", "ySLHbl4+0zW3baq+7fkLbdh9zsJFD7CH2FXuO9SBx58=", new DateTime(2021, 5, 20, 11, 13, 14, 885, DateTimeKind.Local).AddTicks(1515), "Hunter.Kemmer" },
                    { 14, 8, new DateTime(2021, 5, 20, 11, 13, 14, 949, DateTimeKind.Local).AddTicks(9808), "Ewald_Brown15@gmail.com", "nWDeaY8L/6N+Fe0PIwDMFcbtD8CymNncpqw8sms9i7s=", "ubu59TXbBb0pWuax4nkHvFdu1BLWz6lpSf27whkn0Zw=", new DateTime(2021, 5, 20, 11, 13, 14, 949, DateTimeKind.Local).AddTicks(9852), "Nichole.Kulas" },
                    { 11, 8, new DateTime(2021, 5, 20, 11, 13, 14, 922, DateTimeKind.Local).AddTicks(3523), "Sandra58@hotmail.com", "k8R4dwnKEzCNF/gUJhFLkEv4xK5nI1GjvYZySMBXGfU=", "usYqevKzZb+qARv2wZCKcPL7vjZGIQf77wZaG9DWDk4=", new DateTime(2021, 5, 20, 11, 13, 14, 922, DateTimeKind.Local).AddTicks(3584), "Angelina.Krajcik76" },
                    { 9, 8, new DateTime(2021, 5, 20, 11, 13, 14, 904, DateTimeKind.Local).AddTicks(2432), "Giuseppe.Schowalter35@gmail.com", "hZ+2DYV5XXAIOVHgnWBDbfpcg8AQ4zM+9wIJLyAb918=", "hcAUmWfOD0aISKN9HfNk26g/aFy0FNDtKhd/p4b3dO0=", new DateTime(2021, 5, 20, 11, 13, 14, 904, DateTimeKind.Local).AddTicks(2515), "Gino.White66" },
                    { 8, 5, new DateTime(2021, 5, 20, 11, 13, 14, 894, DateTimeKind.Local).AddTicks(4593), "Brycen_Bayer@gmail.com", "aaOiiDbTIa2LHpb3qRNhL89CnRUeVJxi+tSdrX6b4OI=", "I4Gidaxl1CccNkwj4MlceIvNOPqMd17wS2LXcrlqh04=", new DateTime(2021, 5, 20, 11, 13, 14, 894, DateTimeKind.Local).AddTicks(4653), "Chelsie24" },
                    { 13, 4, new DateTime(2021, 5, 20, 11, 13, 14, 940, DateTimeKind.Local).AddTicks(5517), "Reymundo.Hyatt9@hotmail.com", "0t+8Uu4780g97Q47WrMGjg4ZC2NyaZyjhrVAueDckpw=", "k+nKIvhRcAZoCTlvp4jeLaxOc6Mm7mQvpAZpwIXGiZA=", new DateTime(2021, 5, 20, 11, 13, 14, 940, DateTimeKind.Local).AddTicks(5579), "Buck_Reynolds58" },
                    { 6, 4, new DateTime(2021, 5, 20, 11, 13, 14, 875, DateTimeKind.Local).AddTicks(6521), "Emil_Moen50@gmail.com", "Wgxx1H7JzjFDpm110weZvqoahZTXgr7Qe3b5WgxraQk=", "gohkEBKxAZWAwYeggEMnkbA6CM7XnSMXVBfwN82C910=", new DateTime(2021, 5, 20, 11, 13, 14, 875, DateTimeKind.Local).AddTicks(6589), "Jennifer45" },
                    { 1, 3, new DateTime(2021, 5, 20, 11, 13, 14, 826, DateTimeKind.Local).AddTicks(488), "Murray_Schuster79@gmail.com", "acAJ53wZsq31VAb6cMXgUfIax6/m7Y0/RHnoJEnMYEg=", "Rcm3LnHPlpiN5J9LLJYTd0PcilyDDnVc6Nswoyo47j0=", new DateTime(2021, 5, 20, 11, 13, 14, 826, DateTimeKind.Local).AddTicks(1583), "Titus_Kuvalis" },
                    { 17, 9, new DateTime(2021, 5, 20, 11, 13, 14, 979, DateTimeKind.Local).AddTicks(94), "Cory22@hotmail.com", "cC/WtQdyOIXKFdNESGGD3+4le0trUPJBOjDBYWkwGSs=", "vIQ5cLovukqZYHZ7CGBut3nvr4rD4pqucGuIplghdSc=", new DateTime(2021, 5, 20, 11, 13, 14, 979, DateTimeKind.Local).AddTicks(117), "Harrison_Funk" },
                    { 5, 2, new DateTime(2021, 5, 20, 11, 13, 14, 866, DateTimeKind.Local).AddTicks(1579), "Shanna.Wolf62@yahoo.com", "xB+JebeSFso9LfB1R0QWq2UD0oOg7UGYMRPoyZ6i77Y=", "mXrPmUfK+EPvjzmLLdmoZE3H6a37OmSXuCK1tH6cFso=", new DateTime(2021, 5, 20, 11, 13, 14, 866, DateTimeKind.Local).AddTicks(1657), "Natasha_Watsica1" }
                });

            migrationBuilder.InsertData(
                table: "PostReactions",
                columns: new[] { "Id", "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[] { 15, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9649), false, 9, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9654), 20 });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[,]
                {
                    { 5, 19, "Adipisci provident cumque repellendus facilis qui quia quos. Ipsa rem corrupti ut corrupti repellendus et qui eaque sapiente. Et soluta dolores magni qui sit in iusto.", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(5977), 27, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(6025) },
                    { 3, 19, "voluptatum", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(4872), 31, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(4882) },
                    { 6, 3, "Inventore voluptate quia distinctio consectetur. Commodi dolores minima omnis velit occaecati esse esse quidem voluptas. Quos occaecati at deleniti dicta sint aperiam. Reprehenderit laudantium et rerum dolor ab amet.", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(6354), 25, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(6364) },
                    { 20, 16, "Numquam temporibus dolor non commodi error quos earum officia.", new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(3511), 23, new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(3520) },
                    { 17, 18, "maxime", new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(3161), 31, new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(3168) },
                    { 15, 18, "Soluta repudiandae velit.\nIpsam ut enim necessitatibus eius ab quae quasi ex neque.\nConsequatur et in architecto repellat voluptas molestiae provident pariatur.\nEx doloribus et.\nEt non ut quidem iste hic reiciendis et.\nNumquam excepturi quas.", new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(2954), 38, new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(2984) },
                    { 11, 18, "Hic a velit optio corporis dolor voluptatum. At illum labore quia sit voluptate soluta ea. Voluptatum voluptatem aliquam dolor eos corporis soluta. Eum ex et aut eveniet qui ut. Veniam modi magni iure.", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(8574), 36, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(8583) },
                    { 2, 18, "mollitia", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(4623), 30, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(4658) },
                    { 18, 2, "Vel error aut sapiente.", new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(3249), 39, new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(3256) },
                    { 13, 2, "Atque et dicta et minus ipsum et. Laborum ut tenetur tempore ut aut. Sit unde perferendis temporibus distinctio at quidem aut quos vel. Quos consequatur aut impedit tempora ab ea vel. At dolores deleniti expedita et saepe ipsa consequatur provident. Illum repellendus veritatis rem neque est.", new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(1049), 38, new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(1076) },
                    { 16, 20, "Sed sint eveniet.", new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(3100), 28, new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(3108) },
                    { 8, 12, "vitae", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(6487), 32, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(6493) },
                    { 4, 12, "Ut eaque aut sunt occaecati autem. Rerum qui neque in in. Quia ullam fugiat optio unde ex dolor velit quasi unde. Id id ea reiciendis id sit blanditiis assumenda quisquam. Doloribus et est quia fugit ipsa.", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(5624), 38, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(5651) },
                    { 7, 17, "beatae", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(6426), 32, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(6432) },
                    { 14, 7, "quod", new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(1193), 37, new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(1200) },
                    { 19, 11, "ipsam", new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(3302), 31, new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(3309) },
                    { 1, 8, "Ipsa laborum accusantium saepe. Sed numquam sit inventore beatae cumque voluptas et dignissimos voluptates. Earum expedita numquam harum quo voluptatem velit.", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(1719), 40, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(2872) },
                    { 12, 19, "Quasi quis quos illo aperiam autem nisi.", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(8727), 24, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(8735) },
                    { 10, 6, "Et dolores sed. Aspernatur est modi nemo. Labore natus placeat quo quis.", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(8160), 29, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(8234) }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[,]
                {
                    { 9, 14, "Aliquam aut saepe ipsum consequuntur totam quia ipsum autem.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7842), 10, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7850) },
                    { 16, 7, "Libero eligendi excepturi est veniam.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8622), 17, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8629) },
                    { 20, 6, "Quo et ut odio ut.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(9135), 17, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(9144) },
                    { 18, 1, "Aut sed nisi ipsa animi.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8855), 13, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8863) },
                    { 2, 20, "Mollitia et exercitationem aliquam animi iusto est cupiditate.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(6984), 13, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(6997) },
                    { 10, 15, "Asperiores nostrum doloremque animi et.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7989), 16, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7996) },
                    { 7, 21, "Blanditiis sed ea quia.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7628), 20, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7639) },
                    { 15, 18, "Consequuntur ea qui cupiditate quaerat.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8528), 15, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8536) },
                    { 4, 6, "A aliquid quia distinctio enim dolorem.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7193), 3, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7200) },
                    { 1, 17, "Quo sunt necessitatibus impedit nobis repellendus voluptatem.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(5039), 6, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(6199) },
                    { 19, 20, "Repudiandae pariatur eum voluptate expedita.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8949), 4, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8957) },
                    { 12, 21, "Adipisci ut voluptatum eos accusamus dolor.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8164), 4, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8172) },
                    { 11, 14, "Esse vero officia.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8068), 7, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8076) },
                    { 3, 16, "Porro nobis error.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7091), 14, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7098) },
                    { 13, 12, "Sit dolorem aperiam alias maiores voluptates ut hic enim.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8356), 3, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8366) },
                    { 5, 3, "Sit ut harum minus atque quidem molestias sint consectetur.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7306), 5, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7314) },
                    { 17, 4, "Pariatur et aperiam eligendi et explicabo.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8713), 19, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8720) },
                    { 6, 2, "Sapiente inventore nostrum.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7383), 5, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7390) },
                    { 8, 2, "Et dignissimos ut eaque voluptas labore.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7731), 3, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7739) },
                    { 14, 6, "Voluptatem itaque iusto.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8438), 11, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8445) }
                });

            migrationBuilder.InsertData(
                table: "PostReactions",
                columns: new[] { "Id", "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 14, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9616), true, 17, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9621), 10 },
                    { 11, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9520), true, 17, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9525), 16 },
                    { 2, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9192), true, 17, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9203), 5 },
                    { 10, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9487), true, 13, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9492), 18 },
                    { 18, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9744), false, 18, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9750), 2 },
                    { 17, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9713), true, 18, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9718), 4 },
                    { 5, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9315), false, 5, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9321), 8 },
                    { 20, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9811), false, 8, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9817), 11 },
                    { 13, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9582), false, 8, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9588), 1 },
                    { 12, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9551), true, 8, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9556), 2 },
                    { 9, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9452), false, 8, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9457), 18 },
                    { 8, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9417), false, 4, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9423), 2 },
                    { 4, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9281), true, 4, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9287), 6 },
                    { 3, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9248), true, 4, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9254), 1 },
                    { 16, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9681), false, 19, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9686), 12 },
                    { 6, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9350), true, 19, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9355), 14 },
                    { 7, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9383), true, 10, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9389), 8 },
                    { 1, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(7499), true, 2, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(8513), 14 },
                    { 19, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9779), true, 12, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9784), 7 }
                });

            migrationBuilder.InsertData(
                table: "CommentReactions",
                columns: new[] { "Id", "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 16, 3, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5502), true, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5508), 21 },
                    { 3, 6, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(4924), true, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(4934), 6 },
                    { 15, 13, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5470), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5476), 14 },
                    { 9, 13, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5274), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5280), 20 },
                    { 4, 13, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(4985), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(4996), 12 },
                    { 6, 4, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5176), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5182), 7 },
                    { 1, 4, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(3131), true, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(4182), 8 },
                    { 17, 20, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5536), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5541), 16 },
                    { 19, 16, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5599), true, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5605), 21 },
                    { 10, 16, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5307), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5313), 1 },
                    { 18, 15, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5568), true, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5573), 3 },
                    { 8, 14, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5242), true, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5247), 13 },
                    { 13, 18, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5405), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5411), 3 },
                    { 20, 2, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5630), true, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5635), 17 },
                    { 12, 2, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5372), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5378), 1 },
                    { 5, 19, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5131), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5139), 21 },
                    { 11, 12, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5340), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5345), 13 },
                    { 2, 11, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(4838), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(4856), 1 },
                    { 7, 6, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5209), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5215), 17 },
                    { 14, 6, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5438), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5443), 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommentReactions_UserId",
                table: "CommentReactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AuthorId",
                table: "Comments",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostReactions_UserId",
                table: "PostReactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_AuthorId",
                table: "Posts",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PreviewId",
                table: "Posts",
                column: "PreviewId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AvatarId",
                table: "Users",
                column: "AvatarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommentReactions");

            migrationBuilder.DropTable(
                name: "PostReactions");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
