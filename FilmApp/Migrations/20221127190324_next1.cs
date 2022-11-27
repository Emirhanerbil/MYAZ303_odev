using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmApp.Migrations
{
    public partial class next1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DirectorID",
                table: "NextFilmFeatures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_NextFilmFeatures_DirectorID",
                table: "NextFilmFeatures",
                column: "DirectorID");

            migrationBuilder.AddForeignKey(
                name: "FK_NextFilmFeatures_Directors_DirectorID",
                table: "NextFilmFeatures",
                column: "DirectorID",
                principalTable: "Directors",
                principalColumn: "DirectorID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NextFilmFeatures_Directors_DirectorID",
                table: "NextFilmFeatures");

            migrationBuilder.DropIndex(
                name: "IX_NextFilmFeatures_DirectorID",
                table: "NextFilmFeatures");

            migrationBuilder.DropColumn(
                name: "DirectorID",
                table: "NextFilmFeatures");
        }
    }
}
