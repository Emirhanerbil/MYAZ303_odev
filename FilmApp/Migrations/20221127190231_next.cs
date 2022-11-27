using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmApp.Migrations
{
    public partial class next : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "NextFilmFeatures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_NextFilmFeatures_CategoryId",
                table: "NextFilmFeatures",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_NextFilmFeatures_Categories_CategoryId",
                table: "NextFilmFeatures",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NextFilmFeatures_Categories_CategoryId",
                table: "NextFilmFeatures");

            migrationBuilder.DropIndex(
                name: "IX_NextFilmFeatures_CategoryId",
                table: "NextFilmFeatures");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "NextFilmFeatures");
        }
    }
}
