using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayerRepository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GraduateDepartment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExamScore = table.Column<double>(type: "float", nullable: false),
                    OsymRank = table.Column<int>(type: "int", nullable: false),
                    PreferredSection = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreferredCity = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
