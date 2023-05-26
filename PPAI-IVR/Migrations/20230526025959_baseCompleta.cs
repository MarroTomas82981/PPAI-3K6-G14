using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PPAI_IVR.Migrations
{
    /// <inheritdoc />
    public partial class baseCompleta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OpcionLlamadaId",
                table: "Llamadas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OpcionLlamada",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NroOrden = table.Column<int>(type: "int", nullable: false),
                    mensajeSubOpcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    audioMensajeSubOpciones = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpcionLlamada", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CambioEstado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaHoraInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: true),
                    LlamadaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CambioEstado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CambioEstado_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CambioEstado_Llamadas_LlamadaId",
                        column: x => x.LlamadaId,
                        principalTable: "Llamadas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubOpcionLlamada",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nroOrden = table.Column<int>(type: "int", nullable: false),
                    OpcionLlamadaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubOpcionLlamada", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubOpcionLlamada_OpcionLlamada_OpcionLlamadaId",
                        column: x => x.OpcionLlamadaId,
                        principalTable: "OpcionLlamada",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Validacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    audioMensajeValidacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpcionLlamadaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Validacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Validacion_OpcionLlamada_OpcionLlamadaId",
                        column: x => x.OpcionLlamadaId,
                        principalTable: "OpcionLlamada",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InformacionCliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    datoAValidar = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValidacionId = table.Column<int>(type: "int", nullable: true),
                    ClienteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformacionCliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InformacionCliente_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InformacionCliente_Validacion_ValidacionId",
                        column: x => x.ValidacionId,
                        principalTable: "Validacion",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Llamadas_OpcionLlamadaId",
                table: "Llamadas",
                column: "OpcionLlamadaId");

            migrationBuilder.CreateIndex(
                name: "IX_CambioEstado_EstadoId",
                table: "CambioEstado",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_CambioEstado_LlamadaId",
                table: "CambioEstado",
                column: "LlamadaId");

            migrationBuilder.CreateIndex(
                name: "IX_InformacionCliente_ClienteId",
                table: "InformacionCliente",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_InformacionCliente_ValidacionId",
                table: "InformacionCliente",
                column: "ValidacionId");

            migrationBuilder.CreateIndex(
                name: "IX_SubOpcionLlamada_OpcionLlamadaId",
                table: "SubOpcionLlamada",
                column: "OpcionLlamadaId");

            migrationBuilder.CreateIndex(
                name: "IX_Validacion_OpcionLlamadaId",
                table: "Validacion",
                column: "OpcionLlamadaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Llamadas_OpcionLlamada_OpcionLlamadaId",
                table: "Llamadas",
                column: "OpcionLlamadaId",
                principalTable: "OpcionLlamada",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Llamadas_OpcionLlamada_OpcionLlamadaId",
                table: "Llamadas");

            migrationBuilder.DropTable(
                name: "CambioEstado");

            migrationBuilder.DropTable(
                name: "InformacionCliente");

            migrationBuilder.DropTable(
                name: "SubOpcionLlamada");

            migrationBuilder.DropTable(
                name: "Estado");

            migrationBuilder.DropTable(
                name: "Validacion");

            migrationBuilder.DropTable(
                name: "OpcionLlamada");

            migrationBuilder.DropIndex(
                name: "IX_Llamadas_OpcionLlamadaId",
                table: "Llamadas");

            migrationBuilder.DropColumn(
                name: "OpcionLlamadaId",
                table: "Llamadas");
        }
    }
}
