using Microsoft.EntityFrameworkCore.Migrations;

namespace Thread_.NET.DAL.Migrations
{
    public partial class RenameBaseEntityFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "Users",
                newName: "ModifiedOn");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Users",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "Posts",
                newName: "ModifiedOn");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Posts",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "Images",
                newName: "ModifiedOn");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Images",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "Comments",
                newName: "ModifiedOn");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Comments",
                newName: "CreatedOn");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ModifiedOn",
                table: "Users",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "Users",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "ModifiedOn",
                table: "Posts",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "Posts",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "ModifiedOn",
                table: "Images",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "Images",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "ModifiedOn",
                table: "Comments",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "Comments",
                newName: "CreatedDate");
        }
    }
}
