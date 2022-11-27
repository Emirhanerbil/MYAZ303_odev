using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmApp.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Features",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Features_CategoryId",
                table: "Features",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Features_Categories_CategoryId",
                table: "Features",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Features_Categories_CategoryId",
                table: "Features");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Features_CategoryId",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Features");
        }
    }
}
