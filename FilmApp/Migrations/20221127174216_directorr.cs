using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmApp.Migrations
{
    public partial class directorr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Features_Director_DirectorID",
                table: "Features");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Director",
                table: "Director");

            migrationBuilder.RenameTable(
                name: "Director",
                newName: "Directors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Directors",
                table: "Directors",
                column: "DirectorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Features_Directors_DirectorID",
                table: "Features",
                column: "DirectorID",
                principalTable: "Directors",
                principalColumn: "DirectorID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Features_Directors_DirectorID",
                table: "Features");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Directors",
                table: "Directors");

            migrationBuilder.RenameTable(
                name: "Directors",
                newName: "Director");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Director",
                table: "Director",
                column: "DirectorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Features_Director_DirectorID",
                table: "Features",
                column: "DirectorID",
                principalTable: "Director",
                principalColumn: "DirectorID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
