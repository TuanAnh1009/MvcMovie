using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class Table_Loai_Hang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<string>(type: "TEXT", nullable: false),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Hang",
                columns: table => new
                {
                    HangID = table.Column<string>(type: "TEXT", nullable: false),
                    HangName = table.Column<string>(type: "TEXT", nullable: true),
                    Gia = table.Column<float>(type: "REAL", nullable: false),
                    Soluong = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryID = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hang", x => x.HangID);
                    table.ForeignKey(
                        name: "FK_Hang_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hang_CategoryID",
                table: "Hang",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hang");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
