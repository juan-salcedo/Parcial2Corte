using Microsoft.EntityFrameworkCore.Migrations;

namespace DALL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "afiliados",
                columns: table => new
                {
                    CodigoAfiliado = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAfilacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoAfiliado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_afiliados", x => x.CodigoAfiliado);
                });

            migrationBuilder.CreateTable(
                name: "liquidacionIndividuals",
                columns: table => new
                {
                    CodigoLiquidacionIndividual = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoLiquidacionMensual = table.Column<int>(type: "int", nullable: false),
                    CodigoAfiliado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaAfiliacion = table.Column<int>(type: "int", nullable: false),
                    ValorLiquidacion = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_liquidacionIndividuals", x => x.CodigoLiquidacionIndividual);
                });

            migrationBuilder.CreateTable(
                name: "liquidacionMensual",
                columns: table => new
                {
                    CodigoLiquidacionMensual = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MesLiquidar = table.Column<int>(type: "int", nullable: false),
                    Anioliquidar = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdAfiliado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_liquidacionMensual", x => x.CodigoLiquidacionMensual);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "afiliados");

            migrationBuilder.DropTable(
                name: "liquidacionIndividuals");

            migrationBuilder.DropTable(
                name: "liquidacionMensual");
        }
    }
}
