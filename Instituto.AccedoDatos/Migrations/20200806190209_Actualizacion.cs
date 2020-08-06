using Microsoft.EntityFrameworkCore.Migrations;

namespace Instituto.AccedoDatos.Migrations
{
    public partial class Actualizacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JugadorPorPosicion_jugadores_JugadorId",
                table: "JugadorPorPosicion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_jugadores",
                table: "jugadores");

            migrationBuilder.RenameTable(
                name: "jugadores",
                newName: "Jugadores");

            migrationBuilder.AddColumn<int>(
                name: "EquipoId",
                table: "Jugadores",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jugadores",
                table: "Jugadores",
                column: "JugadorId");

            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    EquipoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.EquipoId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jugadores_EquipoId",
                table: "Jugadores",
                column: "EquipoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jugadores_Equipos_EquipoId",
                table: "Jugadores",
                column: "EquipoId",
                principalTable: "Equipos",
                principalColumn: "EquipoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JugadorPorPosicion_Jugadores_JugadorId",
                table: "JugadorPorPosicion",
                column: "JugadorId",
                principalTable: "Jugadores",
                principalColumn: "JugadorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jugadores_Equipos_EquipoId",
                table: "Jugadores");

            migrationBuilder.DropForeignKey(
                name: "FK_JugadorPorPosicion_Jugadores_JugadorId",
                table: "JugadorPorPosicion");

            migrationBuilder.DropTable(
                name: "Equipos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Jugadores",
                table: "Jugadores");

            migrationBuilder.DropIndex(
                name: "IX_Jugadores_EquipoId",
                table: "Jugadores");

            migrationBuilder.DropColumn(
                name: "EquipoId",
                table: "Jugadores");

            migrationBuilder.RenameTable(
                name: "Jugadores",
                newName: "jugadores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_jugadores",
                table: "jugadores",
                column: "JugadorId");

            migrationBuilder.AddForeignKey(
                name: "FK_JugadorPorPosicion_jugadores_JugadorId",
                table: "JugadorPorPosicion",
                column: "JugadorId",
                principalTable: "jugadores",
                principalColumn: "JugadorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
