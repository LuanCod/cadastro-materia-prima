using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cadastro_materia_prima.Migrations
{
    public partial class M01AddTableMateria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Materia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValorEnergetico = table.Column<double>(type: "float", nullable: false),
                    Carboidratos = table.Column<double>(type: "float", nullable: false),
                    AcucaresTotais = table.Column<double>(type: "float", nullable: false),
                    AcucaresAdicionados = table.Column<double>(type: "float", nullable: false),
                    Proteinas = table.Column<double>(type: "float", nullable: false),
                    GordurasTotais = table.Column<double>(type: "float", nullable: false),
                    GordurasSaturadas = table.Column<double>(type: "float", nullable: false),
                    GordurasTrans = table.Column<double>(type: "float", nullable: false),
                    FibraAlimentar = table.Column<double>(type: "float", nullable: false),
                    Sodio = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materia", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Materia");
        }
    }
}
