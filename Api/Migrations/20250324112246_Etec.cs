using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class Etec : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aluno",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RMA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mae = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EscolaID = table.Column<int>(type: "int", nullable: false),
                    ProfessorID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Escola",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlunoID = table.Column<int>(type: "int", nullable: false),
                    ProfessorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escola", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RMA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mae = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompenteCurricular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EscolaID = table.Column<int>(type: "int", nullable: false),
                    AlunoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professor", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aluno");

            migrationBuilder.DropTable(
                name: "Escola");

            migrationBuilder.DropTable(
                name: "Professor");
        }
    }
}
