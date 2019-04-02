using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Thread_.NET.DAL.Migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    URL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    AvatarId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Images_AvatarId",
                        column: x => x.AvatarId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    PreviewId = table.Column<int>(nullable: false),
                    Body = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_Images_PreviewId",
                        column: x => x.PreviewId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reaction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsLike = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reaction_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    PostId = table.Column<int>(nullable: false),
                    Body = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostReactions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    ReactionId = table.Column<int>(nullable: false),
                    PostId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostReactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostReactions_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostReactions_Reaction_ReactionId",
                        column: x => x.ReactionId,
                        principalTable: "Reaction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommentReactions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    ReactionId = table.Column<int>(nullable: false),
                    CommentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentReactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommentReactions_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommentReactions_Reaction_ReactionId",
                        column: x => x.ReactionId,
                        principalTable: "Reaction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedAt", "URL", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 4, 2, 16, 21, 12, 414, DateTimeKind.Local).AddTicks(6772), "https://s3.amazonaws.com/uifaces/faces/twitter/okcoker/128.jpg", new DateTime(2019, 4, 2, 16, 21, 12, 414, DateTimeKind.Local).AddTicks(6772) },
                    { 23, new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(4907), "https://picsum.photos/640/480/?image=798", new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(4907) },
                    { 24, new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(4929), "https://picsum.photos/640/480/?image=1049", new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(4929) },
                    { 25, new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(4948), "https://picsum.photos/640/480/?image=373", new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(4948) },
                    { 26, new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(4966), "https://picsum.photos/640/480/?image=421", new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(4966) },
                    { 27, new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(4983), "https://picsum.photos/640/480/?image=56", new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(4983) },
                    { 28, new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(5068), "https://picsum.photos/640/480/?image=655", new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(5068) },
                    { 29, new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(5089), "https://picsum.photos/640/480/?image=183", new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(5089) },
                    { 22, new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(4836), "https://picsum.photos/640/480/?image=135", new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(4836) },
                    { 30, new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(5107), "https://picsum.photos/640/480/?image=22", new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(5107) },
                    { 32, new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(5141), "https://picsum.photos/640/480/?image=764", new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(5141) },
                    { 33, new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(5159), "https://picsum.photos/640/480/?image=624", new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(5159) },
                    { 34, new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(5175), "https://picsum.photos/640/480/?image=505", new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(5175) },
                    { 35, new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(5192), "https://picsum.photos/640/480/?image=207", new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(5192) },
                    { 36, new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(5210), "https://picsum.photos/640/480/?image=976", new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(5210) },
                    { 37, new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(5227), "https://picsum.photos/640/480/?image=438", new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(5227) },
                    { 38, new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(5244), "https://picsum.photos/640/480/?image=992", new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(5244) },
                    { 31, new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(5124), "https://picsum.photos/640/480/?image=613", new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(5124) },
                    { 21, new DateTime(2019, 4, 2, 16, 21, 12, 432, DateTimeKind.Local).AddTicks(3071), "https://picsum.photos/640/480/?image=894", new DateTime(2019, 4, 2, 16, 21, 12, 432, DateTimeKind.Local).AddTicks(3071) },
                    { 20, new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(1251), "https://s3.amazonaws.com/uifaces/faces/twitter/kojourin/128.jpg", new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(1251) },
                    { 19, new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(1233), "https://s3.amazonaws.com/uifaces/faces/twitter/thinkleft/128.jpg", new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(1233) },
                    { 2, new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(727), "https://s3.amazonaws.com/uifaces/faces/twitter/mateaodviteza/128.jpg", new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(727) },
                    { 3, new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(914), "https://s3.amazonaws.com/uifaces/faces/twitter/charlesrpratt/128.jpg", new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(914) },
                    { 4, new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(946), "https://s3.amazonaws.com/uifaces/faces/twitter/dhooyenga/128.jpg", new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(946) },
                    { 5, new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(969), "https://s3.amazonaws.com/uifaces/faces/twitter/sethlouey/128.jpg", new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(969) },
                    { 6, new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(989), "https://s3.amazonaws.com/uifaces/faces/twitter/s4f1/128.jpg", new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(989) },
                    { 7, new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(1011), "https://s3.amazonaws.com/uifaces/faces/twitter/calebogden/128.jpg", new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(1011) },
                    { 8, new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(1029), "https://s3.amazonaws.com/uifaces/faces/twitter/arashmanteghi/128.jpg", new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(1029) },
                    { 9, new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(1047), "https://s3.amazonaws.com/uifaces/faces/twitter/bistrianiosip/128.jpg", new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(1047) },
                    { 10, new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(1066), "https://s3.amazonaws.com/uifaces/faces/twitter/woodsman001/128.jpg", new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(1066) },
                    { 11, new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(1084), "https://s3.amazonaws.com/uifaces/faces/twitter/h1brd/128.jpg", new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(1084) },
                    { 12, new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(1103), "https://s3.amazonaws.com/uifaces/faces/twitter/klefue/128.jpg", new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(1103) },
                    { 13, new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(1122), "https://s3.amazonaws.com/uifaces/faces/twitter/felipeapiress/128.jpg", new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(1122) },
                    { 14, new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(1139), "https://s3.amazonaws.com/uifaces/faces/twitter/leemunroe/128.jpg", new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(1139) },
                    { 15, new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(1161), "https://s3.amazonaws.com/uifaces/faces/twitter/lawlbwoy/128.jpg", new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(1161) },
                    { 16, new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(1179), "https://s3.amazonaws.com/uifaces/faces/twitter/ZacharyZorbas/128.jpg", new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(1179) },
                    { 17, new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(1197), "https://s3.amazonaws.com/uifaces/faces/twitter/atariboy/128.jpg", new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(1197) },
                    { 18, new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(1216), "https://s3.amazonaws.com/uifaces/faces/twitter/pehamondello/128.jpg", new DateTime(2019, 4, 2, 16, 21, 12, 428, DateTimeKind.Local).AddTicks(1216) },
                    { 39, new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(5260), "https://picsum.photos/640/480/?image=526", new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(5260) },
                    { 40, new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(5277), "https://picsum.photos/640/480/?image=906", new DateTime(2019, 4, 2, 16, 21, 12, 433, DateTimeKind.Local).AddTicks(5277) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { 14, 1, new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(6264), "Evert_Harris@yahoo.com", "HvGH2UcJ", new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(6264), "Paige.Casper95" },
                    { 9, 19, new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(5478), "Hank47@gmail.com", "VPvGsDiF", new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(5478), "Wilfrid71" },
                    { 20, 16, new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(7224), "Laverne.Altenwerth@hotmail.com", "cYvjloAx", new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(7224), "Elliott78" },
                    { 2, 16, new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(3952), "Erna_Stiedemann31@gmail.com", "7ZBu20nv", new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(3952), "Carrie61" },
                    { 11, 15, new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(5829), "Regan_Weimann9@yahoo.com", "OVh4EnSH", new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(5829), "Rasheed95" },
                    { 17, 13, new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(6748), "Odessa97@yahoo.com", "Qdoj3wE1", new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(6748), "Dixie.Marquardt34" },
                    { 8, 13, new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(5302), "Hester_Orn@yahoo.com", "5keAm2rY", new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(5302), "Jaydon.Stehr44" },
                    { 3, 13, new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(4461), "Jarrell.Yundt@gmail.com", "9ZwQOsGX", new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(4461), "Francis_Krajcik65" },
                    { 5, 12, new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(4858), "Oceane36@yahoo.com", "TmUDETOO", new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(4858), "Carey_Schoen48" },
                    { 13, 11, new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(6128), "Angelita_Carter41@gmail.com", "DB5cRJjT", new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(6128), "Arno.Simonis62" },
                    { 18, 10, new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(6927), "Elouise4@gmail.com", "q7yx12PL", new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(6927), "Clara_Schuster43" },
                    { 6, 10, new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(5063), "Reid0@hotmail.com", "tgtz4nFg", new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(5063), "Raleigh13" },
                    { 7, 9, new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(5184), "Hassan84@hotmail.com", "glZffk91", new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(5184), "Xavier99" },
                    { 1, 9, new DateTime(2019, 4, 2, 16, 21, 12, 439, DateTimeKind.Local).AddTicks(2040), "Elissa99@gmail.com", "2z4Q4fqp", new DateTime(2019, 4, 2, 16, 21, 12, 439, DateTimeKind.Local).AddTicks(2040), "Anderson_Koch76" },
                    { 16, 8, new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(6621), "Camryn34@gmail.com", "5zrvA3aC", new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(6621), "Emerson_Gutkowski" },
                    { 12, 7, new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(5961), "Jayde_Barrows@yahoo.com", "2Jm9phJj", new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(5961), "Zelda73" },
                    { 19, 6, new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(7048), "Jarrett28@gmail.com", "ZK1STjgb", new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(7048), "Korbin_Veum34" },
                    { 4, 3, new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(4704), "Cesar_Botsford31@hotmail.com", "ryq18hs1", new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(4704), "Garett_Halvorson" },
                    { 15, 19, new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(6485), "Nathanael80@gmail.com", "f5ZiH8rf", new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(6485), "Brian.Fisher54" },
                    { 10, 20, new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(5600), "Timothy_Mills@yahoo.com", "mO0gFA5K", new DateTime(2019, 4, 2, 16, 21, 12, 447, DateTimeKind.Local).AddTicks(5600), "Talia.Kunde88" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[,]
                {
                    { 9, 14, @"Molestiae rerum non iure quo alias autem.
                Autem et rem sed nesciunt exercitationem.
                Quo necessitatibus numquam eos est deserunt voluptatem aliquid dicta explicabo.", new DateTime(2019, 4, 2, 16, 21, 12, 457, DateTimeKind.Local).AddTicks(6178), 25, new DateTime(2019, 4, 2, 16, 21, 12, 457, DateTimeKind.Local).AddTicks(6178) },
                    { 2, 2, "Esse non quia molestiae quas rerum et fuga.", new DateTime(2019, 4, 2, 16, 21, 12, 455, DateTimeKind.Local).AddTicks(2601), 23, new DateTime(2019, 4, 2, 16, 21, 12, 455, DateTimeKind.Local).AddTicks(2601) },
                    { 6, 2, "placeat", new DateTime(2019, 4, 2, 16, 21, 12, 457, DateTimeKind.Local).AddTicks(4663), 33, new DateTime(2019, 4, 2, 16, 21, 12, 457, DateTimeKind.Local).AddTicks(4663) },
                    { 20, 5, "fugit", new DateTime(2019, 4, 2, 16, 21, 12, 457, DateTimeKind.Local).AddTicks(7987), 21, new DateTime(2019, 4, 2, 16, 21, 12, 457, DateTimeKind.Local).AddTicks(7987) },
                    { 17, 5, "Libero dolores magni eos velit esse eligendi iusto tempora aliquid. Aut quia dolor maiores nesciunt eos dicta. Id et libero officia provident delectus iste omnis blanditiis. Id ea cum et nobis necessitatibus eius vero blanditiis. Doloribus velit beatae repellendus dicta ipsum reprehenderit ut id.", new DateTime(2019, 4, 2, 16, 21, 12, 457, DateTimeKind.Local).AddTicks(7319), 39, new DateTime(2019, 4, 2, 16, 21, 12, 457, DateTimeKind.Local).AddTicks(7319) },
                    { 15, 5, "minus", new DateTime(2019, 4, 2, 16, 21, 12, 457, DateTimeKind.Local).AddTicks(7094), 24, new DateTime(2019, 4, 2, 16, 21, 12, 457, DateTimeKind.Local).AddTicks(7094) },
                    { 7, 10, @"Ex consectetur officiis.
                Labore et nihil sint.
                Quis quaerat sequi qui quibusdam.
                Rerum eos error odio cupiditate.
                Sint corporis distinctio.
                Laudantium accusantium ea error et minima.", new DateTime(2019, 4, 2, 16, 21, 12, 457, DateTimeKind.Local).AddTicks(4719), 21, new DateTime(2019, 4, 2, 16, 21, 12, 457, DateTimeKind.Local).AddTicks(4719) },
                    { 16, 2, @"Accusantium minima nesciunt culpa tempore ea quia impedit.
                Rem incidunt natus iste ex maiores.
                Architecto ea necessitatibus sint aut odio maxime.
                Voluptatem repudiandae ut iure.", new DateTime(2019, 4, 2, 16, 21, 12, 457, DateTimeKind.Local).AddTicks(7131), 40, new DateTime(2019, 4, 2, 16, 21, 12, 457, DateTimeKind.Local).AddTicks(7131) },
                    { 12, 18, "Animi nihil velit fuga rem.", new DateTime(2019, 4, 2, 16, 21, 12, 457, DateTimeKind.Local).AddTicks(6777), 29, new DateTime(2019, 4, 2, 16, 21, 12, 457, DateTimeKind.Local).AddTicks(6777) },
                    { 5, 6, "Ut dolor facere et odio consequatur optio eius debitis fugit. Error officiis aut quis. Possimus perspiciatis distinctio. Laudantium ipsam pariatur vel est. Amet ut tenetur asperiores reiciendis. Consequuntur ut et at omnis aspernatur sequi.", new DateTime(2019, 4, 2, 16, 21, 12, 457, DateTimeKind.Local).AddTicks(4284), 24, new DateTime(2019, 4, 2, 16, 21, 12, 457, DateTimeKind.Local).AddTicks(4284) },
                    { 8, 3, "perspiciatis", new DateTime(2019, 4, 2, 16, 21, 12, 457, DateTimeKind.Local).AddTicks(6127), 36, new DateTime(2019, 4, 2, 16, 21, 12, 457, DateTimeKind.Local).AddTicks(6127) },
                    { 14, 7, "soluta", new DateTime(2019, 4, 2, 16, 21, 12, 457, DateTimeKind.Local).AddTicks(7053), 35, new DateTime(2019, 4, 2, 16, 21, 12, 457, DateTimeKind.Local).AddTicks(7053) },
                    { 19, 7, "facere", new DateTime(2019, 4, 2, 16, 21, 12, 457, DateTimeKind.Local).AddTicks(7947), 24, new DateTime(2019, 4, 2, 16, 21, 12, 457, DateTimeKind.Local).AddTicks(7947) },
                    { 13, 1, "Saepe at quos earum consequuntur rerum. Autem incidunt nihil est. Non nihil numquam alias. Ullam ut neque voluptate. Omnis sunt ab laborum recusandae.", new DateTime(2019, 4, 2, 16, 21, 12, 457, DateTimeKind.Local).AddTicks(6877), 36, new DateTime(2019, 4, 2, 16, 21, 12, 457, DateTimeKind.Local).AddTicks(6877) },
                    { 4, 16, "Quia fuga assumenda dolores veritatis labore aspernatur doloremque. Sapiente deserunt sed doloribus veniam et est. Nesciunt eligendi sit est aliquam.", new DateTime(2019, 4, 2, 16, 21, 12, 456, DateTimeKind.Local).AddTicks(5124), 33, new DateTime(2019, 4, 2, 16, 21, 12, 456, DateTimeKind.Local).AddTicks(5124) },
                    { 3, 16, "Quisquam eos et nemo placeat earum in.", new DateTime(2019, 4, 2, 16, 21, 12, 456, DateTimeKind.Local).AddTicks(4792), 33, new DateTime(2019, 4, 2, 16, 21, 12, 456, DateTimeKind.Local).AddTicks(4792) },
                    { 1, 16, "quidem", new DateTime(2019, 4, 2, 16, 21, 12, 453, DateTimeKind.Local).AddTicks(5083), 24, new DateTime(2019, 4, 2, 16, 21, 12, 453, DateTimeKind.Local).AddTicks(5083) },
                    { 18, 19, "Nulla ut alias unde mollitia quia rerum et ut est. Doloribus eveniet sequi iusto nostrum voluptas. Nobis non vel sed eum. Et commodi in expedita voluptatem perspiciatis natus ut qui soluta. Quo necessitatibus tempore voluptatem minima incidunt suscipit sapiente molestiae. Aspernatur enim ut laudantium ducimus.", new DateTime(2019, 4, 2, 16, 21, 12, 457, DateTimeKind.Local).AddTicks(7624), 23, new DateTime(2019, 4, 2, 16, 21, 12, 457, DateTimeKind.Local).AddTicks(7624) },
                    { 10, 19, @"Voluptas voluptate quia non animi neque doloribus.
                Qui eum dicta non est cumque assumenda maxime at ipsum.
                Impedit officiis et accusamus.", new DateTime(2019, 4, 2, 16, 21, 12, 457, DateTimeKind.Local).AddTicks(6421), 32, new DateTime(2019, 4, 2, 16, 21, 12, 457, DateTimeKind.Local).AddTicks(6421) },
                    { 11, 8, "Exercitationem deserunt ipsam cumque dolore quis. Et sit tempora. Est nulla ut reprehenderit voluptatum est veritatis velit. Ipsam ut reprehenderit occaecati totam perspiciatis quidem vero. Fuga perferendis optio similique unde fuga incidunt.", new DateTime(2019, 4, 2, 16, 21, 12, 457, DateTimeKind.Local).AddTicks(6595), 22, new DateTime(2019, 4, 2, 16, 21, 12, 457, DateTimeKind.Local).AddTicks(6595) }
                });

            migrationBuilder.InsertData(
                table: "Reaction",
                columns: new[] { "Id", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 4, 2, 16, 21, 12, 464, DateTimeKind.Local).AddTicks(6080), false, new DateTime(2019, 4, 2, 16, 21, 12, 464, DateTimeKind.Local).AddTicks(6080), 20 },
                    { 9, new DateTime(2019, 4, 2, 16, 21, 12, 466, DateTimeKind.Local).AddTicks(21), false, new DateTime(2019, 4, 2, 16, 21, 12, 466, DateTimeKind.Local).AddTicks(21), 9 },
                    { 6, new DateTime(2019, 4, 2, 16, 21, 12, 465, DateTimeKind.Local).AddTicks(9971), true, new DateTime(2019, 4, 2, 16, 21, 12, 465, DateTimeKind.Local).AddTicks(9971), 2 },
                    { 10, new DateTime(2019, 4, 2, 16, 21, 12, 466, DateTimeKind.Local).AddTicks(38), false, new DateTime(2019, 4, 2, 16, 21, 12, 466, DateTimeKind.Local).AddTicks(38), 9 },
                    { 5, new DateTime(2019, 4, 2, 16, 21, 12, 465, DateTimeKind.Local).AddTicks(9953), true, new DateTime(2019, 4, 2, 16, 21, 12, 465, DateTimeKind.Local).AddTicks(9953), 15 },
                    { 20, new DateTime(2019, 4, 2, 16, 21, 12, 466, DateTimeKind.Local).AddTicks(207), true, new DateTime(2019, 4, 2, 16, 21, 12, 466, DateTimeKind.Local).AddTicks(207), 15 },
                    { 7, new DateTime(2019, 4, 2, 16, 21, 12, 465, DateTimeKind.Local).AddTicks(9987), true, new DateTime(2019, 4, 2, 16, 21, 12, 465, DateTimeKind.Local).AddTicks(9987), 9 },
                    { 14, new DateTime(2019, 4, 2, 16, 21, 12, 466, DateTimeKind.Local).AddTicks(105), false, new DateTime(2019, 4, 2, 16, 21, 12, 466, DateTimeKind.Local).AddTicks(105), 13 },
                    { 18, new DateTime(2019, 4, 2, 16, 21, 12, 466, DateTimeKind.Local).AddTicks(174), false, new DateTime(2019, 4, 2, 16, 21, 12, 466, DateTimeKind.Local).AddTicks(174), 5 },
                    { 4, new DateTime(2019, 4, 2, 16, 21, 12, 465, DateTimeKind.Local).AddTicks(9933), false, new DateTime(2019, 4, 2, 16, 21, 12, 465, DateTimeKind.Local).AddTicks(9933), 5 },
                    { 13, new DateTime(2019, 4, 2, 16, 21, 12, 466, DateTimeKind.Local).AddTicks(88), true, new DateTime(2019, 4, 2, 16, 21, 12, 466, DateTimeKind.Local).AddTicks(88), 13 },
                    { 19, new DateTime(2019, 4, 2, 16, 21, 12, 466, DateTimeKind.Local).AddTicks(190), false, new DateTime(2019, 4, 2, 16, 21, 12, 466, DateTimeKind.Local).AddTicks(190), 6 },
                    { 11, new DateTime(2019, 4, 2, 16, 21, 12, 466, DateTimeKind.Local).AddTicks(54), true, new DateTime(2019, 4, 2, 16, 21, 12, 466, DateTimeKind.Local).AddTicks(54), 7 },
                    { 17, new DateTime(2019, 4, 2, 16, 21, 12, 466, DateTimeKind.Local).AddTicks(155), false, new DateTime(2019, 4, 2, 16, 21, 12, 466, DateTimeKind.Local).AddTicks(155), 1 },
                    { 16, new DateTime(2019, 4, 2, 16, 21, 12, 466, DateTimeKind.Local).AddTicks(138), false, new DateTime(2019, 4, 2, 16, 21, 12, 466, DateTimeKind.Local).AddTicks(138), 16 },
                    { 12, new DateTime(2019, 4, 2, 16, 21, 12, 466, DateTimeKind.Local).AddTicks(71), true, new DateTime(2019, 4, 2, 16, 21, 12, 466, DateTimeKind.Local).AddTicks(71), 12 },
                    { 3, new DateTime(2019, 4, 2, 16, 21, 12, 465, DateTimeKind.Local).AddTicks(9906), true, new DateTime(2019, 4, 2, 16, 21, 12, 465, DateTimeKind.Local).AddTicks(9906), 12 },
                    { 2, new DateTime(2019, 4, 2, 16, 21, 12, 465, DateTimeKind.Local).AddTicks(9741), false, new DateTime(2019, 4, 2, 16, 21, 12, 465, DateTimeKind.Local).AddTicks(9741), 14 },
                    { 15, new DateTime(2019, 4, 2, 16, 21, 12, 466, DateTimeKind.Local).AddTicks(121), true, new DateTime(2019, 4, 2, 16, 21, 12, 466, DateTimeKind.Local).AddTicks(121), 11 },
                    { 8, new DateTime(2019, 4, 2, 16, 21, 12, 466, DateTimeKind.Local).AddTicks(4), false, new DateTime(2019, 4, 2, 16, 21, 12, 466, DateTimeKind.Local).AddTicks(4), 10 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[,]
                {
                    { 5, 12, "Necessitatibus esse qui rerum ut aut vero unde suscipit quae.", new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(2775), 9, new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(2775) },
                    { 2, 10, "Quod cupiditate rerum eos voluptatem autem inventore ullam.", new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(2261), 17, new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(2261) },
                    { 15, 13, "Aut sit necessitatibus exercitationem et.", new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(3536), 2, new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(3536) },
                    { 13, 2, "Laudantium nihil quia at accusamus magnam.", new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(3399), 15, new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(3399) },
                    { 1, 16, "Illo necessitatibus id quae illo necessitatibus placeat.", new DateTime(2019, 4, 2, 16, 21, 12, 485, DateTimeKind.Local).AddTicks(1335), 15, new DateTime(2019, 4, 2, 16, 21, 12, 485, DateTimeKind.Local).AddTicks(1335) },
                    { 20, 4, "Excepturi laboriosam excepturi eligendi debitis cum tenetur.", new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(3889), 12, new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(3889) },
                    { 4, 17, "Eaque ducimus blanditiis non laboriosam quod repellat accusamus autem assumenda.", new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(2627), 5, new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(2627) },
                    { 19, 8, "Quo aliquid iste maxime id sit alias corrupti provident omnis.", new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(3825), 19, new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(3825) },
                    { 12, 8, "Magnam eaque odit possimus impedit omnis quibusdam explicabo et id.", new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(3331), 8, new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(3331) },
                    { 8, 7, "Enim minima dolores.", new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(2988), 4, new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(2988) },
                    { 16, 8, "Odit ut quasi et dolore est aut eos.", new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(3594), 4, new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(3594) },
                    { 10, 13, "Eos reiciendis eum eos laboriosam voluptatem laborum dolore repellendus.", new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(3092), 3, new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(3092) },
                    { 9, 18, "Ex nihil ea.", new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(3041), 3, new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(3041) },
                    { 6, 15, "Debitis voluptatem eaque non molestiae soluta quidem.", new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(2855), 3, new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(2855) },
                    { 14, 4, "Assumenda labore suscipit impedit.", new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(3456), 1, new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(3456) },
                    { 17, 6, "Nobis consequatur ipsam qui numquam laboriosam ut quasi.", new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(3703), 18, new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(3703) },
                    { 3, 2, "Quisquam nulla nesciunt et totam aut est minus omnis corporis.", new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(2536), 18, new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(2536) },
                    { 7, 8, "Laboriosam provident a quo nulla vitae molestiae architecto sit.", new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(2918), 10, new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(2918) },
                    { 11, 10, "Perferendis dolorem aut.", new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(3269), 9, new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(3269) },
                    { 18, 10, "Alias mollitia est omnis corrupti qui.", new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(3769), 3, new DateTime(2019, 4, 2, 16, 21, 12, 486, DateTimeKind.Local).AddTicks(3769) }
                });

            migrationBuilder.InsertData(
                table: "PostReactions",
                columns: new[] { "Id", "CreatedAt", "PostId", "ReactionId", "UpdatedAt" },
                values: new object[,]
                {
                    { 10, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4373), 15, 7, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4373) },
                    { 5, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4270), 8, 9, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4270) },
                    { 14, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4460), 6, 9, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4460) },
                    { 12, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4415), 10, 10, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4415) },
                    { 4, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4248), 4, 10, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4248) },
                    { 8, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4331), 12, 6, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4331) },
                    { 13, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4434), 2, 10, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4434) },
                    { 3, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4219), 6, 10, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4219) },
                    { 6, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4291), 5, 6, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4291) },
                    { 15, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4481), 15, 16, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4481) },
                    { 1, new DateTime(2019, 4, 2, 16, 21, 12, 490, DateTimeKind.Local).AddTicks(6201), 16, 17, new DateTime(2019, 4, 2, 16, 21, 12, 490, DateTimeKind.Local).AddTicks(6201) },
                    { 17, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4520), 6, 16, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4520) },
                    { 2, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4076), 6, 14, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4076) },
                    { 20, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4578), 15, 15, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4578) },
                    { 11, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4395), 11, 11, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4395) },
                    { 7, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4311), 7, 17, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4311) },
                    { 9, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4351), 1, 11, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4351) },
                    { 16, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4501), 3, 17, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4501) },
                    { 18, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4539), 16, 11, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4539) },
                    { 19, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4558), 7, 2, new DateTime(2019, 4, 2, 16, 21, 12, 491, DateTimeKind.Local).AddTicks(4558) }
                });

            migrationBuilder.InsertData(
                table: "CommentReactions",
                columns: new[] { "Id", "CommentId", "CreatedAt", "ReactionId", "UpdatedAt" },
                values: new object[,]
                {
                    { 9, 5, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8142), 6, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8142) },
                    { 6, 13, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8082), 7, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8082) },
                    { 4, 1, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8040), 14, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8040) },
                    { 2, 1, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(7851), 7, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(7851) },
                    { 20, 4, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8448), 17, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8448) },
                    { 18, 4, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8410), 15, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8410) },
                    { 16, 4, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8371), 11, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8371) },
                    { 10, 8, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8163), 16, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8163) },
                    { 1, 8, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(874), 1, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(874) },
                    { 19, 10, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8429), 4, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8429) },
                    { 15, 10, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8351), 16, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8351) },
                    { 7, 9, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8103), 13, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8103) },
                    { 8, 6, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8123), 1, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8123) },
                    { 13, 3, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8312), 11, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8312) },
                    { 5, 3, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8061), 6, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8061) },
                    { 3, 7, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8009), 14, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8009) },
                    { 14, 11, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8332), 9, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8332) },
                    { 11, 5, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8181), 18, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8181) },
                    { 17, 13, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8391), 7, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8391) },
                    { 12, 15, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8209), 8, new DateTime(2019, 4, 2, 16, 21, 12, 495, DateTimeKind.Local).AddTicks(8209) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommentReactions_CommentId",
                table: "CommentReactions",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentReactions_ReactionId",
                table: "CommentReactions",
                column: "ReactionId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AuthorId",
                table: "Comments",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostReactions_PostId",
                table: "PostReactions",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostReactions_ReactionId",
                table: "PostReactions",
                column: "ReactionId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_AuthorId",
                table: "Posts",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PreviewId",
                table: "Posts",
                column: "PreviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Reaction_UserId",
                table: "Reaction",
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
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Reaction");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
