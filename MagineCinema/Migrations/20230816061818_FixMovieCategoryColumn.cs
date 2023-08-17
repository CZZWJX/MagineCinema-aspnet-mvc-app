using Microsoft.EntityFrameworkCore.Migrations;

namespace MagineCinema.Migrations
{
    public partial class FixMovieCategoryColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.RenameColumn(
                name: "movieCategory",
                table: "Movie",
                newName: "movieCategories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "movieCategories",
                table: "Movie",
                newName: "movieCategory");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    movieId = table.Column<int>(type: "int", nullable: false),
                    movieCategory = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => new { x.movieId, x.movieCategory });
                    table.ForeignKey(
                        name: "FK_Category_Movie_movieId",
                        column: x => x.movieId,
                        principalTable: "Movie",
                        principalColumn: "movieId",
                        onDelete: ReferentialAction.Cascade);
                });
        }
    }
}
