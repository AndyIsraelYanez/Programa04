using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto.AccesoDatos.Migrations
{
    public partial class MasCambios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entrenadores",
                columns: table => new
                {
                    EntrenadorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrenadores", x => x.EntrenadorId);
                });

            migrationBuilder.CreateTable(
                name: "JugadorPorEntrenador",
                columns: table => new
                {
                    EntrenadorId = table.Column<int>(nullable: false),
                    JugadorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JugadorPorEntrenador", x => new { x.EntrenadorId, x.JugadorId });
                    table.ForeignKey(
                        name: "FK_JugadorPorEntrenador_Entrenadores_EntrenadorId",
                        column: x => x.EntrenadorId,
                        principalTable: "Entrenadores",
                        principalColumn: "EntrenadorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JugadorPorEntrenador_Jugadores_JugadorId",
                        column: x => x.JugadorId,
                        principalTable: "Jugadores",
                        principalColumn: "JugadorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JugadorPorEntrenador_JugadorId",
                table: "JugadorPorEntrenador",
                column: "JugadorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JugadorPorEntrenador");

            migrationBuilder.DropTable(
                name: "Entrenadores");
        }
    }
}
