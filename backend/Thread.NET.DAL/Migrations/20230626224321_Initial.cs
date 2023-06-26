using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Thread.NET.DAL.Migrations
{
    public partial class Initial : Migration
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
                        principalColumn: "Id");
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
                    { 1, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1249.jpg", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/892.jpg", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/778.jpg", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/100.jpg", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/801.jpg", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/698.jpg", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/499.jpg", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/24.jpg", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/650.jpg", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/755.jpg", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/906.jpg", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1163.jpg", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/540.jpg", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/109.jpg", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/34.jpg", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1008.jpg", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/428.jpg", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/532.jpg", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/31.jpg", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/105.jpg", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://picsum.photos/640/480/?image=64", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://picsum.photos/640/480/?image=594", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://picsum.photos/640/480/?image=685", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://picsum.photos/640/480/?image=176", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://picsum.photos/640/480/?image=178", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://picsum.photos/640/480/?image=331", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://picsum.photos/640/480/?image=29", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://picsum.photos/640/480/?image=167", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://picsum.photos/640/480/?image=863", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://picsum.photos/640/480/?image=654", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://picsum.photos/640/480/?image=428", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://picsum.photos/640/480/?image=415", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://picsum.photos/640/480/?image=1056", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://picsum.photos/640/480/?image=979", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://picsum.photos/640/480/?image=220", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://picsum.photos/640/480/?image=843", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://picsum.photos/640/480/?image=1001", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://picsum.photos/640/480/?image=115", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://picsum.photos/640/480/?image=1071", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://picsum.photos/640/480/?image=780", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 21, null, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@gmail.com", "ZIKxzVnLJOHVWLAoH4p3PZMwNkw1Ri4r80uNhuVflJQ=", "GgxGb1115NitZ2XV9RnbyCt8NDs3+IUA7F5kAFOTsw0=", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "testUser" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { 1, 18, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anita.Kertzmann1@hotmail.com", "wGldFTDLNeU8Ja2pAG0WGFZdtJH+iawx/Luw0MC4wVs=", "GgxGb1115NitZ2XV9RnbyCt8NDs3+IUA7F5kAFOTsw0=", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Krystal26" },
                    { 2, 7, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jett36@gmail.com", "OOE84phsNW5PvkaqDfxG7NNVfssnDUaNR6Ttq82Qhi4=", "GgxGb1115NitZ2XV9RnbyCt8NDs3+IUA7F5kAFOTsw0=", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Demarcus43" },
                    { 3, 1, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sydney.Walsh59@gmail.com", "AbOhZ5/yinAOPgtxys9dPqWWLa0Xjhjf2g/vxeLB/rs=", "GgxGb1115NitZ2XV9RnbyCt8NDs3+IUA7F5kAFOTsw0=", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finn52" },
                    { 4, 15, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elza_Rutherford29@hotmail.com", "v+MhPkVI8yCKvDqKcOY16xbGcLL0Z5uTvwq0OtPMlmk=", "GgxGb1115NitZ2XV9RnbyCt8NDs3+IUA7F5kAFOTsw0=", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pansy12" },
                    { 5, 3, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elenora_Jacobs@gmail.com", "bRngtZsr8x4PTD8LQf9vmMplaXmo2bbh7wwP1s6exaY=", "GgxGb1115NitZ2XV9RnbyCt8NDs3+IUA7F5kAFOTsw0=", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kasandra99" },
                    { 6, 18, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Estella_Kuphal@yahoo.com", "uh2UfGOV/PZrviJm1Yi34tQY8tTrNv3qf94R3wiS6OM=", "GgxGb1115NitZ2XV9RnbyCt8NDs3+IUA7F5kAFOTsw0=", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crystal71" },
                    { 7, 6, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marilou52@yahoo.com", "zyqQzSxgnwVfBAQ36HXNkkgqJv6E9opoOV2ZSRD6RjU=", "GgxGb1115NitZ2XV9RnbyCt8NDs3+IUA7F5kAFOTsw0=", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carson_Sipes62" },
                    { 8, 12, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clint22@gmail.com", "4TcsVCFkWxteRaffmZuCsHJuvzVhrfu46rG3Fw3WOYI=", "GgxGb1115NitZ2XV9RnbyCt8NDs3+IUA7F5kAFOTsw0=", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rahsaan_Heathcote76" },
                    { 9, 8, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dewitt_Fritsch56@hotmail.com", "4QrgVIn+6E59w2m5VkKTUciZCECH2XAOfYVPZPUwVws=", "GgxGb1115NitZ2XV9RnbyCt8NDs3+IUA7F5kAFOTsw0=", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mona.Farrell" },
                    { 10, 8, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Janet_Jast51@hotmail.com", "tg1Y8aU28baETa4lwypwRqTMYThJIlxl02Uz4EPgHTk=", "GgxGb1115NitZ2XV9RnbyCt8NDs3+IUA7F5kAFOTsw0=", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yasmin_Wisoky33" },
                    { 11, 13, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lavina_Toy57@hotmail.com", "/qQ0DOLRZi7YC5e3X8B4b5c3OIdvzuwyvuJtXXRdk0s=", "GgxGb1115NitZ2XV9RnbyCt8NDs3+IUA7F5kAFOTsw0=", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Santos91" },
                    { 12, 16, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chet79@yahoo.com", "qQo/tZNMRG2KGNpeDhkMDugp38ZC0u0peef9Xgs1nRc=", "GgxGb1115NitZ2XV9RnbyCt8NDs3+IUA7F5kAFOTsw0=", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lydia67" },
                    { 13, 20, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abbigail_Upton@gmail.com", "KLicGLMyJ99AE74AO69rJcocEBiLLULiL6g9pC+aTxo=", "GgxGb1115NitZ2XV9RnbyCt8NDs3+IUA7F5kAFOTsw0=", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tony.Wolff" },
                    { 14, 12, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jodie81@yahoo.com", "s+3eSS2Lxq8mSlhrMb6U2gNdrctIdqFnDQUs7dcl3EI=", "GgxGb1115NitZ2XV9RnbyCt8NDs3+IUA7F5kAFOTsw0=", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brown43" },
                    { 15, 10, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bernadine.Beahan@yahoo.com", "hS5hHEflHfhP6v8+IpNtnbU7HLeaF9kFstvugYzgjxs=", "GgxGb1115NitZ2XV9RnbyCt8NDs3+IUA7F5kAFOTsw0=", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magdalena_Ankunding14" },
                    { 16, 5, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Garnet13@yahoo.com", "KwFLl2TdvD2m8II2ykNr6ZgXExdnSfCfGsAuxgP7PrU=", "GgxGb1115NitZ2XV9RnbyCt8NDs3+IUA7F5kAFOTsw0=", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joy_Predovic49" },
                    { 17, 20, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marisol_Kovacek@gmail.com", "Tv7khvjcyJHdeHOdiMb0KBeNLjK7Wap0YWPvyWvgIiA=", "GgxGb1115NitZ2XV9RnbyCt8NDs3+IUA7F5kAFOTsw0=", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vivien_Auer81" },
                    { 18, 9, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mortimer_Wolff@hotmail.com", "RcZH5xGDognu02SfyAoOE12q0DUpS2YFDBTG7z++9Bs=", "GgxGb1115NitZ2XV9RnbyCt8NDs3+IUA7F5kAFOTsw0=", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fidel_Becker92" },
                    { 19, 4, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Burdette.Stokes@hotmail.com", "WxevqRsSOU1GzY5gwJlC8P4duqqHoiXGIxWNAHnl3OM=", "GgxGb1115NitZ2XV9RnbyCt8NDs3+IUA7F5kAFOTsw0=", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emelia.Volkman87" },
                    { 20, 9, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sadie_Ebert@hotmail.com", "P18V0otDpgB5fQWoYZ+3jDBJLa0cPRGKyZPQbulmr5c=", "GgxGb1115NitZ2XV9RnbyCt8NDs3+IUA7F5kAFOTsw0=", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dovie77" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 14, "Reiciendis cupiditate reprehenderit sed vel in accusamus sapiente molestiae incidunt.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, "Suscipit saepe beatae qui.\nDelectus voluptatem est neque doloribus ipsa sit id ut.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 6, "Quidem qui sed quos vel.\nQuod est facilis iusto tempore.\nDolorem voluptatibus blanditiis voluptas praesentium nam.\nQui molestiae quo et tempora numquam suscipit.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 12, "Eaque amet corporis occaecati.\nEt in cumque natus quasi ex dolorum nostrum corrupti.\nNumquam aperiam voluptatem voluptates dolore consequatur recusandae.\nReprehenderit et mollitia enim minima ipsa cumque deleniti aut et.\nQuidem aliquam cupiditate laudantium.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 11, "sapiente", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 10, "Id libero sed cupiditate aut illum voluptatum.\nAut nemo voluptates mollitia modi quos quia expedita eos.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 12, "Nostrum eligendi sunt excepturi eum amet voluptate rerum commodi.\nEum dicta sunt est et quia consequatur veritatis ducimus.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 15, "Esse eaque recusandae corporis amet et explicabo in blanditiis. Autem molestiae tenetur animi iusto quis nihil eius rerum sunt. Dolores sint excepturi id nobis tempora velit dolore est. Ut vitae impedit explicabo ut. Aut optio odio qui molestiae.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 17, "dolores", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 7, "Ipsam alias cupiditate explicabo veniam sed quam similique quas optio.\nVoluptatem aut error accusantium ut et quas sunt.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 4, "Laboriosam quas tempora minima labore.\nPraesentium repellendus sunt libero consequatur ut.\nLaborum vel tempora fugiat provident adipisci quod.\nMinima dolorem consequuntur.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 18, "Consequuntur distinctio quibusdam quos neque facere omnis. Qui voluptas ipsa labore ut veritatis eos iste soluta temporibus. Est et velit temporibus quia voluptas ipsam veritatis. Aspernatur et sunt deleniti velit dolore sapiente consequatur.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 12, "Eaque sit est quia voluptatem quas ratione eius est.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 18, "Sunt tempore molestiae officiis rem.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 4, "Beatae ut natus eaque et aspernatur magni ut dolorem.\nAssumenda et provident excepturi qui quia.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 17, "Sed minus magni fuga sunt eaque dolores. Quia perspiciatis dolorem itaque ut laborum ut officia. Quos sed iste modi nihil sapiente. Et qui esse quis ullam totam soluta. Aut voluptatem ut quas molestiae esse vitae veritatis asperiores. Cumque at animi quo asperiores eveniet laborum.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 1, "Nemo fugiat est omnis nihil molestiae.\nNulla dignissimos et eos voluptatem eum ad.\nLaudantium nesciunt ab.\nInventore error laborum consequatur odit reiciendis.\nVoluptatem sint cum quo.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 15, "cum", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 6, "Et odio voluptatem dolorem quae asperiores veniam rerum.\nDolorem ratione nihil maxime ut nam accusamus eligendi.\nNam sunt dolores minima odit ipsum qui reiciendis vero.\nVoluptatem voluptatem commodi minus.\nLaboriosam facere et velit ducimus.\nFugit optio voluptatem et est non nostrum non id praesentium.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 6, "Numquam autem sit reiciendis odio. Dolores sunt id. Praesentium esse qui voluptate excepturi ab.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 16, "Unde officiis dolor nulla quam facilis odio ab sed.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 3, "Atque libero reiciendis.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 13, "Iusto aut necessitatibus reiciendis id.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 9, "Fugit voluptatem occaecati modi.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, "Aut sint et.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 6, "Suscipit alias sit sit ea qui nisi reiciendis maxime neque.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 7, "Voluptatem labore reiciendis sunt enim mollitia vel consectetur provident.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 1, "Voluptatem doloribus ipsa rem voluptatem perspiciatis dicta pariatur quis aut.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 17, "Dolore amet est magnam consequatur maiores ut sunt est sit.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 7, "Neque odio quo est aut quo corrupti quia ipsa ea.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 13, "Et velit veniam reprehenderit sint incidunt odit.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 15, "Quia itaque neque corporis exercitationem aut.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 14, "Dignissimos quia eum facilis eos.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 16, "Iure quo sed repellendus reprehenderit.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 20, "Eaque aut aliquam velit unde.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 9, "Aperiam officia repellendus rerum.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 5, "Quis maxime doloremque veritatis iure.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 17, "Maxime dolorum recusandae porro.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 6, "Minus consectetur reprehenderit recusandae aliquam repellat esse.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 5, "Officiis dolore est unde eos expedita necessitatibus.", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "PostReactions",
                columns: new[] { "Id", "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 3, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 11, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 4, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 5, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 5, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 9, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 6, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 6, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 7, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 7, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 8, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 9, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 20, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 10, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 18, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 11, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 11, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 12, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 12, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 13, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 14, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 7, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 15, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 16, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 19, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 17, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 18, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 19, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 11, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 20, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 18, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "CommentReactions",
                columns: new[] { "Id", "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 2, 12, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 3, 7, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 4, 2, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 5, 4, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 6, 1, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 7, 5, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 8, 19, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 9, 13, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 10, 3, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 11, 8, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 12, 5, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 13, 13, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 14, 1, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 15, 5, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 16, 15, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, 17, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 18, 19, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 19, 16, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, 6, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
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
