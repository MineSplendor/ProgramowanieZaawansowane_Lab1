using Microsoft.EntityFrameworkCore.Migrations;

namespace AdvancedProgramming_Lesson1.Migrations.MvcBookList
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pages = table.Column<int>(nullable: false),
                    Release = table.Column<int>(nullable: false),
                    Circulation = table.Column<int>(nullable: false),
                    Rate = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookList", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookList");
        }
    }
}
