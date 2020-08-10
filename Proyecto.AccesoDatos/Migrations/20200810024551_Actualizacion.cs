using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto.AccesoDatos.Migrations
{
    public partial class Actualizacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    EquipoId = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.EquipoId);
                });

            migrationBuilder.CreateTable(
                name: "TipoPosiciones",
                columns: table => new
                {
                    TipoPosicionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPosiciones", x => x.TipoPosicionId);
                });

            migrationBuilder.CreateTable(
                name: "Jugadores",
                columns: table => new
                {
                    JugadorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    Nacimiento = table.Column<DateTime>(nullable: false),
                    EquipoId = table.Column<int>(nullable: false),
                    EquipoId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugadores", x => x.JugadorId);
                    table.ForeignKey(
                        name: "FK_Jugadores_Equipos_EquipoId1",
                        column: x => x.EquipoId1,
                        principalTable: "Equipos",
                        principalColumn: "EquipoId",
                        onDelete: ReferentialAction.Restrict);
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
                        name: "FK_JugadorPorPosicion_Jugadores_JugadorId",
                        column: x => x.JugadorId,
                        principalTable: "Jugadores",
                        principalColumn: "JugadorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JugadorPorPosicion_TipoPosiciones_TipoPosicionId",
                        column: x => x.TipoPosicionId,
                        principalTable: "TipoPosiciones",
                        principalColumn: "TipoPosicionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Uniformes",
                columns: table => new
                {
                    UniformeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JugadorId = table.Column<int>(nullable: false),
                    Modelo = table.Column<string>(nullable: true),
                    Marca = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uniformes", x => x.UniformeId);
                    table.ForeignKey(
                        name: "FK_Uniformes_Jugadores_JugadorId",
                        column: x => x.JugadorId,
                        principalTable: "Jugadores",
                        principalColumn: "JugadorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jugadores_EquipoId1",
                table: "Jugadores",
                column: "EquipoId1");

            migrationBuilder.CreateIndex(
                name: "IX_JugadorPorPosicion_JugadorId",
                table: "JugadorPorPosicion",
                column: "JugadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Uniformes_JugadorId",
                table: "Uniformes",
                column: "JugadorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JugadorPorPosicion");

            migrationBuilder.DropTable(
                name: "Uniformes");

            migrationBuilder.DropTable(
                name: "TipoPosiciones");

            migrationBuilder.DropTable(
                name: "Jugadores");

            migrationBuilder.DropTable(
                name: "Equipos");
        }
    }
}
