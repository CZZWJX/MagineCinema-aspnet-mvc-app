using Microsoft.EntityFrameworkCore.Migrations;

namespace MagineCinema.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Movie_movieId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "movieCategoryId",
                table: "Category");

            migrationBuilder.AlterColumn<int>(
                name: "movieId",
                table: "Category",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Movie_movieId",
                table: "Category",
                column: "movieId",
                principalTable: "Movie",
                principalColumn: "movieId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Movie_movieId",
                table: "Category");

            migrationBuilder.AlterColumn<int>(
                name: "movieId",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "movieCategoryId",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Movie_movieId",
                table: "Category",
                column: "movieId",
                principalTable: "Movie",
                principalColumn: "movieId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
