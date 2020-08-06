using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Instituto.AccedoDatos.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "jugadores",
                columns: table => new
                {
                    JugadorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    Nacimiento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jugadores", x => x.JugadorId);
                });

            migrationBuilder.CreateTable(
                name: "TipoPosiciones",
                columns: table => new
                {
                    IdTipoPosicion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPosiciones", x => x.IdTipoPosicion);
                });

            migrationBuilder.CreateTable(
                name: "JugadorPorPosicion",
                columns: table => new
                {
                    JugadorId = table.Column<int>(nullable: false),
                    TipoPosicionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JugadorPorPosicion", x => new { x.TipoPosicionId, x.JugadorId });
                    table.ForeignKey(
                        name: "FK_JugadorPorPosicion_jugadores_JugadorId",
                        column: x => x.JugadorId,
                        principalTable: "jugadores",
                        principalColumn: "JugadorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JugadorPorPosicion_TipoPosiciones_TipoPosicionId",
                        column: x => x.TipoPosicionId,
                        principalTable: "TipoPosiciones",
                        principalColumn: "IdTipoPosicion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JugadorPorPosicion_JugadorId",
                table: "JugadorPorPosicion",
                column: "JugadorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JugadorPorPosicion");

            migrationBuilder.DropTable(
                name: "jugadores");

            migrationBuilder.DropTable(
                name: "TipoPosiciones");
        }
    }
}
