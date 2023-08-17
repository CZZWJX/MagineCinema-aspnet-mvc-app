using Microsoft.EntityFrameworkCore.Migrations;

namespace MagineCinema.Migrations
{
    public partial class Initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Movie_movieId",
                table: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_movieId",
                table: "Category");

            migrationBuilder.RenameColumn(
                name: "mcValue",
                table: "Category",
                newName: "movieCategory");

            migrationBuilder.AlterColumn<int>(
                name: "movieId",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                columns: new[] { "movieId", "movieCategory" });

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Movie_movieId",
                table: "Category",
                column: "movieId",
                principalTable: "Movie",
                principalColumn: "movieId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Movie_movieId",
                table: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameColumn(
                name: "movieCategory",
                table: "Category",
                newName: "mcValue");

            migrationBuilder.AlterColumn<int>(
                name: "movieId",
                table: "Category",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "mcValue");

            migrationBuilder.CreateIndex(
                name: "IX_Category_movieId",
                table: "Category",
                column: "movieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Movie_movieId",
                table: "Category",
                column: "movieId",
                principalTable: "Movie",
                principalColumn: "movieId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
