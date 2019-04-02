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
                    AvatarId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
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
                    UserId = table.Column<int>(nullable: false),
                    IsLike = table.Column<bool>(nullable: false),
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    IsLike = table.Column<bool>(nullable: false),
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
                    { 1, new DateTime(2019, 4, 2, 18, 8, 29, 851, DateTimeKind.Local).AddTicks(8476), "https://s3.amazonaws.com/uifaces/faces/twitter/g3d/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 851, DateTimeKind.Local).AddTicks(8476) },
                    { 23, new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3511), "https://picsum.photos/640/480/?image=563", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3511) },
                    { 24, new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3531), "https://picsum.photos/640/480/?image=478", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3531) },
                    { 25, new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3548), "https://picsum.photos/640/480/?image=740", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3548) },
                    { 26, new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3565), "https://picsum.photos/640/480/?image=771", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3565) },
                    { 27, new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3581), "https://picsum.photos/640/480/?image=277", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3581) },
                    { 28, new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3658), "https://picsum.photos/640/480/?image=1081", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3658) },
                    { 29, new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3680), "https://picsum.photos/640/480/?image=1060", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3680) },
                    { 22, new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3438), "https://picsum.photos/640/480/?image=497", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3438) },
                    { 30, new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3697), "https://picsum.photos/640/480/?image=404", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3697) },
                    { 32, new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3730), "https://picsum.photos/640/480/?image=583", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3730) },
                    { 33, new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3745), "https://picsum.photos/640/480/?image=402", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3745) },
                    { 34, new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3761), "https://picsum.photos/640/480/?image=613", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3761) },
                    { 35, new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3776), "https://picsum.photos/640/480/?image=392", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3776) },
                    { 36, new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3792), "https://picsum.photos/640/480/?image=109", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3792) },
                    { 37, new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3808), "https://picsum.photos/640/480/?image=727", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3808) },
                    { 38, new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3823), "https://picsum.photos/640/480/?image=498", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3823) },
                    { 31, new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3714), "https://picsum.photos/640/480/?image=1017", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3714) },
                    { 21, new DateTime(2019, 4, 2, 18, 8, 29, 868, DateTimeKind.Local).AddTicks(3159), "https://picsum.photos/640/480/?image=104", new DateTime(2019, 4, 2, 18, 8, 29, 868, DateTimeKind.Local).AddTicks(3159) },
                    { 20, new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3926), "https://s3.amazonaws.com/uifaces/faces/twitter/kolsvein/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3926) },
                    { 19, new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3912), "https://s3.amazonaws.com/uifaces/faces/twitter/teylorfeliz/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3912) },
                    { 2, new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3449), "https://s3.amazonaws.com/uifaces/faces/twitter/johnsmithagency/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3449) },
                    { 3, new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3638), "https://s3.amazonaws.com/uifaces/faces/twitter/hiemil/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3638) },
                    { 4, new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3667), "https://s3.amazonaws.com/uifaces/faces/twitter/shesgared/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3667) },
                    { 5, new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3686), "https://s3.amazonaws.com/uifaces/faces/twitter/uxpiper/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3686) },
                    { 6, new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3703), "https://s3.amazonaws.com/uifaces/faces/twitter/anatolinicolae/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3703) },
                    { 7, new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3721), "https://s3.amazonaws.com/uifaces/faces/twitter/borantula/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3721) },
                    { 8, new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3737), "https://s3.amazonaws.com/uifaces/faces/twitter/jeremyshimko/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3737) },
                    { 9, new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3754), "https://s3.amazonaws.com/uifaces/faces/twitter/geshan/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3754) },
                    { 10, new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3770), "https://s3.amazonaws.com/uifaces/faces/twitter/devankoshal/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3770) },
                    { 11, new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3786), "https://s3.amazonaws.com/uifaces/faces/twitter/mattlat/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3786) },
                    { 12, new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3801), "https://s3.amazonaws.com/uifaces/faces/twitter/codysanfilippo/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3801) },
                    { 13, new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3817), "https://s3.amazonaws.com/uifaces/faces/twitter/jonathansimmons/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3817) },
                    { 14, new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3833), "https://s3.amazonaws.com/uifaces/faces/twitter/iqbalperkasa/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3833) },
                    { 15, new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3848), "https://s3.amazonaws.com/uifaces/faces/twitter/jcubic/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3848) },
                    { 16, new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3867), "https://s3.amazonaws.com/uifaces/faces/twitter/zauerkraut/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3867) },
                    { 17, new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3882), "https://s3.amazonaws.com/uifaces/faces/twitter/syropian/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3882) },
                    { 18, new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3897), "https://s3.amazonaws.com/uifaces/faces/twitter/plasticine/128.jpg", new DateTime(2019, 4, 2, 18, 8, 29, 864, DateTimeKind.Local).AddTicks(3897) },
                    { 39, new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3838), "https://picsum.photos/640/480/?image=946", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3838) },
                    { 40, new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3854), "https://picsum.photos/640/480/?image=708", new DateTime(2019, 4, 2, 18, 8, 29, 869, DateTimeKind.Local).AddTicks(3854) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AvatarId", "CreatedAt", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { 7, 1, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(6605), "Joannie.Christiansen83@yahoo.com", "ksM16tDk", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(6605), "Jeffery_Stiedemann90" },
                    { 15, 16, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(7844), "Shaun20@hotmail.com", "dz1r35Nk", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(7844), "Larue_Kris" },
                    { 17, 15, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(8142), "Jared16@yahoo.com", "mAmrecut", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(8142), "Hattie67" },
                    { 6, 14, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(6431), "Lela_Schmidt@hotmail.com", "OcY7QhHd", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(6431), "Guy_Waelchi" },
                    { 4, 13, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(6088), "Gregorio_Hettinger@hotmail.com", "qdfNRCD1", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(6088), "Sarah_Von72" },
                    { 1, 12, new DateTime(2019, 4, 2, 18, 8, 29, 875, DateTimeKind.Local).AddTicks(8202), "Ena71@gmail.com", "Ykta0p3j", new DateTime(2019, 4, 2, 18, 8, 29, 875, DateTimeKind.Local).AddTicks(8202), "Jon.Hoppe" },
                    { 9, 11, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(6983), "Eugene82@gmail.com", "06MJIRXF", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(6983), "Oral.Harvey" },
                    { 16, 9, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(8013), "Anna74@hotmail.com", "WkSw14l1", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(8013), "Braeden.Reichert16" },
                    { 13, 8, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(7602), "Ashleigh.Kunde@hotmail.com", "rR5wowmT", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(7602), "Genevieve.Mante68" },
                    { 5, 8, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(6301), "Paul_Bosco1@yahoo.com", "oFaePi37", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(6301), "Dasia1" },
                    { 10, 6, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(7115), "Cullen47@yahoo.com", "gAiqI6LH", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(7115), "Christina.Prosacco96" },
                    { 2, 6, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(5286), "Clyde46@hotmail.com", "kMdcqBC2", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(5286), "Lucius12" },
                    { 11, 5, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(7288), "Eda.Bergstrom78@gmail.com", "MFAXZThC", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(7288), "Lawrence.Corwin51" },
                    { 19, 3, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(8435), "Stuart68@gmail.com", "34UcXcu1", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(8435), "Helen84" },
                    { 12, 3, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(7425), "Marilyne8@hotmail.com", "hG35chpF", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(7425), "Astrid.Johnson" },
                    { 8, 2, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(6798), "Vicente75@yahoo.com", "6RBimjs1", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(6798), "Major_Crooks" },
                    { 3, 2, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(5899), "Travis_Orn25@yahoo.com", "rIQMu8t1", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(5899), "Eleanora74" },
                    { 20, 1, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(8630), "Celestine30@hotmail.com", "67Cu_ULu", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(8630), "Eleanora_Grady" },
                    { 18, 16, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(8309), "Alfred_Gorczany5@yahoo.com", "RKfonEhf", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(8309), "Dannie_Macejkovic" },
                    { 14, 20, new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(7727), "Winona_Hagenes@gmail.com", "EcB7pQ6g", new DateTime(2019, 4, 2, 18, 8, 29, 882, DateTimeKind.Local).AddTicks(7727), "Aimee_Dooley7" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[,]
                {
                    { 8, 7, "Et qui aut pariatur ut tempora velit ad reprehenderit animi. Voluptates reiciendis qui repellat. Alias ipsa est dolores consectetur maxime sed qui autem. Optio quia et vero ea cum eveniet asperiores cum. Omnis facere pariatur consequuntur aut.", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(5723), 33, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(5723) },
                    { 2, 18, "velit", new DateTime(2019, 4, 2, 18, 8, 29, 891, DateTimeKind.Local).AddTicks(9946), 39, new DateTime(2019, 4, 2, 18, 8, 29, 891, DateTimeKind.Local).AddTicks(9946) },
                    { 17, 15, @"A sapiente dolores fugit in incidunt officia.
                Est nulla iusto voluptatum consequuntur.", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(7350), 29, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(7350) },
                    { 11, 17, "Corrupti quos ad natus quasi. Minima voluptate mollitia cum. Aut nisi dolorem velit et. Animi ipsa quaerat et impedit sequi quia impedit.", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(6536), 26, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(6536) },
                    { 9, 17, @"Esse eos dolore quae.
                Aspernatur consectetur voluptate quisquam sed veniam est.
                Odio non quia ex provident velit.
                Perferendis voluptatibus qui facilis alias dolore.
                Deleniti magnam perspiciatis voluptate.", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(6021), 40, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(6021) },
                    { 1, 17, @"Hic eos omnis consequatur.
                Quo saepe natus quidem.
                Deserunt ipsa sapiente ut optio aut rem molestiae eos eius.", new DateTime(2019, 4, 2, 18, 8, 29, 888, DateTimeKind.Local).AddTicks(8294), 30, new DateTime(2019, 4, 2, 18, 8, 29, 888, DateTimeKind.Local).AddTicks(8294) },
                    { 13, 4, "Qui in officiis ut repellendus aut in aliquam. Et rerum sapiente rerum fugit ea fugiat. In dolor suscipit. Pariatur repellendus quis. Ut et et consequatur dolorum qui ipsum soluta est dolores.", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(6858), 21, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(6858) },
                    { 3, 1, @"Excepturi a nesciunt recusandae corrupti quis odio voluptatum minima quae.
                Deleniti fugit voluptatem facere aut sit.
                Et ea aliquid molestiae id.", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(689), 38, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(689) },
                    { 14, 13, "Dolorem culpa et.", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(7082), 23, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(7082) },
                    { 5, 2, "debitis", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(3936), 33, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(3936) },
                    { 4, 11, "Aliquid rerum ea dolorem expedita id consequuntur a. Odit voluptatum soluta quaerat et consectetur. Ducimus quod consequatur perspiciatis voluptatum odio.", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(1010), 39, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(1010) },
                    { 20, 19, @"Asperiores quia et maxime nihil quasi soluta ea.
                Explicabo rerum atque adipisci fugiat adipisci tempore.
                Modi veniam temporibus sit.", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(7641), 29, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(7641) },
                    { 18, 12, "saepe", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(7436), 32, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(7436) },
                    { 15, 12, "aliquid", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(7132), 23, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(7132) },
                    { 19, 8, "Aliquam molestiae et asperiores. Dolores qui sed et animi minima qui et. Temporibus odit culpa aut quasi cupiditate officia. Quia cumque et.", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(7467), 35, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(7467) },
                    { 7, 3, "qui", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(5676), 31, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(5676) },
                    { 10, 20, "vel", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(6496), 37, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(6496) },
                    { 16, 7, "Quos non sit. Id autem qui consequatur iusto reiciendis ratione. Voluptatibus sed totam veniam modi voluptatibus. Distinctio aut minima a possimus. Quod voluptatem sunt laborum.", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(7162), 25, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(7162) },
                    { 12, 18, "Eligendi dolore deleniti.", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(6781), 24, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(6781) },
                    { 6, 14, "Sint qui qui aut quia.", new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(4006), 28, new DateTime(2019, 4, 2, 18, 8, 29, 892, DateTimeKind.Local).AddTicks(4006) }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[,]
                {
                    { 20, 20, "Non pariatur autem deserunt delectus necessitatibus qui et autem.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6859), 6, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6859) },
                    { 19, 3, "Molestiae fugit sed eius.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6808), 9, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6808) },
                    { 14, 15, "Ea maxime error similique inventore voluptatem neque animi odit neque.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6479), 11, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6479) },
                    { 8, 10, "Est autem labore facere rem sequi nulla sit animi.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6071), 13, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6071) },
                    { 1, 19, "Fuga qui aut qui vel et dolores pariatur eos.", new DateTime(2019, 4, 2, 18, 8, 29, 898, DateTimeKind.Local).AddTicks(4923), 13, new DateTime(2019, 4, 2, 18, 8, 29, 898, DateTimeKind.Local).AddTicks(4923) },
                    { 11, 4, "Ipsam ab nesciunt magnam id ipsam.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6252), 17, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6252) },
                    { 18, 20, "Et non eaque id.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6708), 17, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6708) },
                    { 5, 1, "Natus delectus hic.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(5808), 14, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(5808) },
                    { 17, 18, "Fugit occaecati eos quis.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6664), 20, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6664) },
                    { 16, 6, "Quidem quisquam soluta natus adipisci impedit impedit qui consequatur ut.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6604), 9, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6604) },
                    { 10, 6, "Quia ex animi suscipit ut est officia.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6197), 20, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6197) },
                    { 15, 16, "Necessitatibus ullam consectetur cupiditate ea fugiat iste.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6549), 20, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6549) },
                    { 9, 4, "Velit deleniti quo quisquam cumque.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6144), 18, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6144) },
                    { 6, 17, "Eaque fuga ut modi explicabo laudantium eligendi quam error commodi.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(5860), 19, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(5860) },
                    { 7, 5, "Consequuntur occaecati tempora et tempora iusto reprehenderit repellat officia nemo.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(5938), 2, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(5938) },
                    { 4, 6, "Rerum non eos voluptatem omnis impedit perspiciatis.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(5744), 10, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(5744) },
                    { 3, 19, "Excepturi reiciendis quidem aut.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(5680), 10, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(5680) },
                    { 13, 8, "Nisi qui occaecati.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6427), 16, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6427) },
                    { 12, 6, "Soluta dicta sint cupiditate ipsa in aliquid vel tenetur iste.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6303), 18, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(6303) },
                    { 2, 15, "Quia dolores et.", new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(5459), 9, new DateTime(2019, 4, 2, 18, 8, 29, 899, DateTimeKind.Local).AddTicks(5459) }
                });

            migrationBuilder.InsertData(
                table: "PostReactions",
                columns: new[] { "Id", "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 19, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1761), true, 17, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1761), 10 },
                    { 10, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1492), false, 17, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1492), 2 },
                    { 15, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1595), false, 11, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1595), 12 },
                    { 1, new DateTime(2019, 4, 2, 18, 8, 29, 906, DateTimeKind.Local).AddTicks(5856), true, 2, new DateTime(2019, 4, 2, 18, 8, 29, 906, DateTimeKind.Local).AddTicks(5856), 4 },
                    { 11, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1513), true, 2, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1513), 17 },
                    { 20, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1781), false, 2, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1781), 7 },
                    { 7, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1430), false, 3, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1430), 7 },
                    { 17, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1659), false, 13, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1659), 7 },
                    { 6, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1411), false, 13, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1411), 16 },
                    { 13, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1552), true, 12, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1552), 19 },
                    { 18, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1738), false, 14, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1738), 11 },
                    { 12, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1533), true, 14, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1533), 11 },
                    { 4, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1367), true, 14, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1367), 9 },
                    { 8, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1452), false, 4, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1452), 7 },
                    { 2, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1179), true, 10, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1179), 11 },
                    { 9, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1472), false, 16, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1472), 10 },
                    { 3, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1336), false, 16, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1336), 16 },
                    { 14, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1576), true, 8, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1576), 11 },
                    { 16, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1615), true, 1, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1615), 9 },
                    { 5, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1390), false, 8, new DateTime(2019, 4, 2, 18, 8, 29, 908, DateTimeKind.Local).AddTicks(1390), 12 }
                });

            migrationBuilder.InsertData(
                table: "CommentReactions",
                columns: new[] { "Id", "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 20, 13, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(2156), false, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(2156), 14 },
                    { 4, 18, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1679), false, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1679), 10 },
                    { 13, 11, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(2007), false, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(2007), 15 },
                    { 1, 14, new DateTime(2019, 4, 2, 18, 8, 29, 914, DateTimeKind.Local).AddTicks(4119), false, new DateTime(2019, 4, 2, 18, 8, 29, 914, DateTimeKind.Local).AddTicks(4119), 16 },
                    { 16, 16, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(2073), false, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(2073), 16 },
                    { 12, 16, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1983), false, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1983), 8 },
                    { 8, 16, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1823), false, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1823), 7 },
                    { 5, 16, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1703), true, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1703), 16 },
                    { 7, 2, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1799), false, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1799), 11 },
                    { 3, 2, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1647), false, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1647), 10 },
                    { 10, 1, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1867), true, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1867), 7 },
                    { 18, 17, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(2114), true, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(2114), 5 },
                    { 6, 15, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1724), false, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1724), 7 },
                    { 19, 10, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(2135), true, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(2135), 19 },
                    { 11, 12, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1909), false, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1909), 4 },
                    { 2, 12, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1498), false, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1498), 1 },
                    { 9, 6, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1844), true, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(1844), 8 },
                    { 17, 3, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(2093), false, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(2093), 8 },
                    { 15, 18, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(2051), false, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(2051), 18 },
                    { 14, 20, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(2029), false, new DateTime(2019, 4, 2, 18, 8, 29, 915, DateTimeKind.Local).AddTicks(2029), 11 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommentReactions_CommentId",
                table: "CommentReactions",
                column: "CommentId");

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
                name: "IX_PostReactions_PostId",
                table: "PostReactions",
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
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
