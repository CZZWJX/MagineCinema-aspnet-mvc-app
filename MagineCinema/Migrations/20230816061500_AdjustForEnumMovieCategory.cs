using Microsoft.EntityFrameworkCore.Migrations;

namespace MagineCinema.Migrations
{
    public partial class AdjustForEnumMovieCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "movieCategory",
                table: "Movie",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "movieCategory",
                table: "Movie");
        }
    }
}
