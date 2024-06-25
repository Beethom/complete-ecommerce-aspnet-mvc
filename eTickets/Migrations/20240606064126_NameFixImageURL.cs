using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    public partial class NameFixImageURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfilePictureUrl",
                table: "Producers",
                newName: "ProfilePictureURL");

            migrationBuilder.RenameColumn(
                name: "movieCategory",
                table: "Movies",
                newName: "MovieCategory");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Movies",
                newName: "ImageURL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfilePictureURL",
                table: "Producers",
                newName: "ProfilePictureUrl");

            migrationBuilder.RenameColumn(
                name: "MovieCategory",
                table: "Movies",
                newName: "movieCategory");

            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "Movies",
                newName: "ImageUrl");
        }
    }
}
