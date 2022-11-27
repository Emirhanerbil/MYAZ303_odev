using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmApp.Migrations
{
    public partial class director : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DirectorID",
                table: "Features",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Director",
                columns: table => new
                {
                    DirectorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DirectorName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Director", x => x.DirectorID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Features_DirectorID",
                table: "Features",
                column: "DirectorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Features_Director_DirectorID",
                table: "Features",
                column: "DirectorID",
                principalTable: "Director",
                principalColumn: "DirectorID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Features_Director_DirectorID",
                table: "Features");

            migrationBuilder.DropTable(
                name: "Director");

            migrationBuilder.DropIndex(
                name: "IX_Features_DirectorID",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "DirectorID",
                table: "Features");
        }
    }
}
