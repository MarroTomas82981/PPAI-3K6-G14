using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PPAI_IVR.Migrations
{
    /// <inheritdoc />
    public partial class baseCompleta4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CambioEstado_Llamadas_LlamadaId",
                table: "CambioEstado");

            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Llamadas_LlamadaId",
                table: "Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_Estado_CambioEstado_CambioEstadoId",
                table: "Estado");

            migrationBuilder.DropForeignKey(
                name: "FK_InformacionCliente_Cliente_ClienteId",
                table: "InformacionCliente");

            migrationBuilder.DropForeignKey(
                name: "FK_InformacionCliente_Validacion_ValidacionId",
                table: "InformacionCliente");

            migrationBuilder.DropForeignKey(
                name: "FK_OpcionLlamada_Llamadas_LlamadaId",
                table: "OpcionLlamada");

            migrationBuilder.DropForeignKey(
                name: "FK_SubOpcionLlamada_OpcionLlamada_opcionLlamadaId",
                table: "SubOpcionLlamada");

            migrationBuilder.DropForeignKey(
                name: "FK_Validacion_OpcionLlamada_opcionLlamadaId",
                table: "Validacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Validacion",
                table: "Validacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubOpcionLlamada",
                table: "SubOpcionLlamada");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OpcionLlamada",
                table: "OpcionLlamada");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InformacionCliente",
                table: "InformacionCliente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Estado",
                table: "Estado");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CambioEstado",
                table: "CambioEstado");

            migrationBuilder.RenameTable(
                name: "Validacion",
                newName: "ValidacionClientes");

            migrationBuilder.RenameTable(
                name: "SubOpcionLlamada",
                newName: "SubOpcionLlamadas");

            migrationBuilder.RenameTable(
                name: "OpcionLlamada",
                newName: "OpcionLlamadas");

            migrationBuilder.RenameTable(
                name: "InformacionCliente",
                newName: "InformacionClientes");

            migrationBuilder.RenameTable(
                name: "Estado",
                newName: "Estados");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "Clientes");

            migrationBuilder.RenameTable(
                name: "CambioEstado",
                newName: "CambiosDeEstado");

            migrationBuilder.RenameIndex(
                name: "IX_Validacion_opcionLlamadaId",
                table: "ValidacionClientes",
                newName: "IX_ValidacionClientes_opcionLlamadaId");

            migrationBuilder.RenameIndex(
                name: "IX_SubOpcionLlamada_opcionLlamadaId",
                table: "SubOpcionLlamadas",
                newName: "IX_SubOpcionLlamadas_opcionLlamadaId");

            migrationBuilder.RenameIndex(
                name: "IX_OpcionLlamada_LlamadaId",
                table: "OpcionLlamadas",
                newName: "IX_OpcionLlamadas_LlamadaId");

            migrationBuilder.RenameIndex(
                name: "IX_InformacionCliente_ValidacionId",
                table: "InformacionClientes",
                newName: "IX_InformacionClientes_ValidacionId");

            migrationBuilder.RenameIndex(
                name: "IX_InformacionCliente_ClienteId",
                table: "InformacionClientes",
                newName: "IX_InformacionClientes_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Estado_CambioEstadoId",
                table: "Estados",
                newName: "IX_Estados_CambioEstadoId");

            migrationBuilder.RenameIndex(
                name: "IX_Cliente_LlamadaId",
                table: "Clientes",
                newName: "IX_Clientes_LlamadaId");

            migrationBuilder.RenameIndex(
                name: "IX_CambioEstado_LlamadaId",
                table: "CambiosDeEstado",
                newName: "IX_CambiosDeEstado_LlamadaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ValidacionClientes",
                table: "ValidacionClientes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubOpcionLlamadas",
                table: "SubOpcionLlamadas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OpcionLlamadas",
                table: "OpcionLlamadas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InformacionClientes",
                table: "InformacionClientes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estados",
                table: "Estados",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CambiosDeEstado",
                table: "CambiosDeEstado",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CategoriaLlamadas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    audioMensajeOpciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mensajeOpciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nroOrden = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaLlamadas", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CambiosDeEstado_Llamadas_LlamadaId",
                table: "CambiosDeEstado",
                column: "LlamadaId",
                principalTable: "Llamadas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Llamadas_LlamadaId",
                table: "Clientes",
                column: "LlamadaId",
                principalTable: "Llamadas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Estados_CambiosDeEstado_CambioEstadoId",
                table: "Estados",
                column: "CambioEstadoId",
                principalTable: "CambiosDeEstado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InformacionClientes_Clientes_ClienteId",
                table: "InformacionClientes",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InformacionClientes_ValidacionClientes_ValidacionId",
                table: "InformacionClientes",
                column: "ValidacionId",
                principalTable: "ValidacionClientes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OpcionLlamadas_Llamadas_LlamadaId",
                table: "OpcionLlamadas",
                column: "LlamadaId",
                principalTable: "Llamadas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubOpcionLlamadas_OpcionLlamadas_opcionLlamadaId",
                table: "SubOpcionLlamadas",
                column: "opcionLlamadaId",
                principalTable: "OpcionLlamadas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ValidacionClientes_OpcionLlamadas_opcionLlamadaId",
                table: "ValidacionClientes",
                column: "opcionLlamadaId",
                principalTable: "OpcionLlamadas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CambiosDeEstado_Llamadas_LlamadaId",
                table: "CambiosDeEstado");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Llamadas_LlamadaId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Estados_CambiosDeEstado_CambioEstadoId",
                table: "Estados");

            migrationBuilder.DropForeignKey(
                name: "FK_InformacionClientes_Clientes_ClienteId",
                table: "InformacionClientes");

            migrationBuilder.DropForeignKey(
                name: "FK_InformacionClientes_ValidacionClientes_ValidacionId",
                table: "InformacionClientes");

            migrationBuilder.DropForeignKey(
                name: "FK_OpcionLlamadas_Llamadas_LlamadaId",
                table: "OpcionLlamadas");

            migrationBuilder.DropForeignKey(
                name: "FK_SubOpcionLlamadas_OpcionLlamadas_opcionLlamadaId",
                table: "SubOpcionLlamadas");

            migrationBuilder.DropForeignKey(
                name: "FK_ValidacionClientes_OpcionLlamadas_opcionLlamadaId",
                table: "ValidacionClientes");

            migrationBuilder.DropTable(
                name: "CategoriaLlamadas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ValidacionClientes",
                table: "ValidacionClientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubOpcionLlamadas",
                table: "SubOpcionLlamadas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OpcionLlamadas",
                table: "OpcionLlamadas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InformacionClientes",
                table: "InformacionClientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Estados",
                table: "Estados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CambiosDeEstado",
                table: "CambiosDeEstado");

            migrationBuilder.RenameTable(
                name: "ValidacionClientes",
                newName: "Validacion");

            migrationBuilder.RenameTable(
                name: "SubOpcionLlamadas",
                newName: "SubOpcionLlamada");

            migrationBuilder.RenameTable(
                name: "OpcionLlamadas",
                newName: "OpcionLlamada");

            migrationBuilder.RenameTable(
                name: "InformacionClientes",
                newName: "InformacionCliente");

            migrationBuilder.RenameTable(
                name: "Estados",
                newName: "Estado");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "Cliente");

            migrationBuilder.RenameTable(
                name: "CambiosDeEstado",
                newName: "CambioEstado");

            migrationBuilder.RenameIndex(
                name: "IX_ValidacionClientes_opcionLlamadaId",
                table: "Validacion",
                newName: "IX_Validacion_opcionLlamadaId");

            migrationBuilder.RenameIndex(
                name: "IX_SubOpcionLlamadas_opcionLlamadaId",
                table: "SubOpcionLlamada",
                newName: "IX_SubOpcionLlamada_opcionLlamadaId");

            migrationBuilder.RenameIndex(
                name: "IX_OpcionLlamadas_LlamadaId",
                table: "OpcionLlamada",
                newName: "IX_OpcionLlamada_LlamadaId");

            migrationBuilder.RenameIndex(
                name: "IX_InformacionClientes_ValidacionId",
                table: "InformacionCliente",
                newName: "IX_InformacionCliente_ValidacionId");

            migrationBuilder.RenameIndex(
                name: "IX_InformacionClientes_ClienteId",
                table: "InformacionCliente",
                newName: "IX_InformacionCliente_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Estados_CambioEstadoId",
                table: "Estado",
                newName: "IX_Estado_CambioEstadoId");

            migrationBuilder.RenameIndex(
                name: "IX_Clientes_LlamadaId",
                table: "Cliente",
                newName: "IX_Cliente_LlamadaId");

            migrationBuilder.RenameIndex(
                name: "IX_CambiosDeEstado_LlamadaId",
                table: "CambioEstado",
                newName: "IX_CambioEstado_LlamadaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Validacion",
                table: "Validacion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubOpcionLlamada",
                table: "SubOpcionLlamada",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OpcionLlamada",
                table: "OpcionLlamada",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InformacionCliente",
                table: "InformacionCliente",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estado",
                table: "Estado",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CambioEstado",
                table: "CambioEstado",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CambioEstado_Llamadas_LlamadaId",
                table: "CambioEstado",
                column: "LlamadaId",
                principalTable: "Llamadas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Llamadas_LlamadaId",
                table: "Cliente",
                column: "LlamadaId",
                principalTable: "Llamadas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Estado_CambioEstado_CambioEstadoId",
                table: "Estado",
                column: "CambioEstadoId",
                principalTable: "CambioEstado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InformacionCliente_Cliente_ClienteId",
                table: "InformacionCliente",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InformacionCliente_Validacion_ValidacionId",
                table: "InformacionCliente",
                column: "ValidacionId",
                principalTable: "Validacion",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OpcionLlamada_Llamadas_LlamadaId",
                table: "OpcionLlamada",
                column: "LlamadaId",
                principalTable: "Llamadas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubOpcionLlamada_OpcionLlamada_opcionLlamadaId",
                table: "SubOpcionLlamada",
                column: "opcionLlamadaId",
                principalTable: "OpcionLlamada",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Validacion_OpcionLlamada_opcionLlamadaId",
                table: "Validacion",
                column: "opcionLlamadaId",
                principalTable: "OpcionLlamada",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
