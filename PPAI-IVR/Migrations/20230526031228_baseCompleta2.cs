using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PPAI_IVR.Migrations
{
    /// <inheritdoc />
    public partial class baseCompleta2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CambioEstado_Estado_EstadoId",
                table: "CambioEstado");

            migrationBuilder.DropForeignKey(
                name: "FK_CambioEstado_Llamadas_LlamadaId",
                table: "CambioEstado");

            migrationBuilder.DropForeignKey(
                name: "FK_InformacionCliente_Cliente_ClienteId",
                table: "InformacionCliente");

            migrationBuilder.DropForeignKey(
                name: "FK_Llamadas_Cliente_ClienteId",
                table: "Llamadas");

            migrationBuilder.DropForeignKey(
                name: "FK_Llamadas_OpcionLlamada_OpcionLlamadaId",
                table: "Llamadas");

            migrationBuilder.DropForeignKey(
                name: "FK_SubOpcionLlamada_OpcionLlamada_OpcionLlamadaId",
                table: "SubOpcionLlamada");

            migrationBuilder.DropForeignKey(
                name: "FK_Validacion_OpcionLlamada_OpcionLlamadaId",
                table: "Validacion");

            migrationBuilder.DropIndex(
                name: "IX_Llamadas_ClienteId",
                table: "Llamadas");

            migrationBuilder.DropIndex(
                name: "IX_Llamadas_OpcionLlamadaId",
                table: "Llamadas");

            migrationBuilder.DropIndex(
                name: "IX_CambioEstado_EstadoId",
                table: "CambioEstado");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Llamadas");

            migrationBuilder.DropColumn(
                name: "OpcionLlamadaId",
                table: "Llamadas");

            migrationBuilder.DropColumn(
                name: "EstadoId",
                table: "CambioEstado");

            migrationBuilder.RenameColumn(
                name: "OpcionLlamadaId",
                table: "Validacion",
                newName: "opcionLlamadaId");

            migrationBuilder.RenameIndex(
                name: "IX_Validacion_OpcionLlamadaId",
                table: "Validacion",
                newName: "IX_Validacion_opcionLlamadaId");

            migrationBuilder.RenameColumn(
                name: "OpcionLlamadaId",
                table: "SubOpcionLlamada",
                newName: "opcionLlamadaId");

            migrationBuilder.RenameIndex(
                name: "IX_SubOpcionLlamada_OpcionLlamadaId",
                table: "SubOpcionLlamada",
                newName: "IX_SubOpcionLlamada_opcionLlamadaId");

            migrationBuilder.AlterColumn<int>(
                name: "opcionLlamadaId",
                table: "Validacion",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "opcionLlamadaId",
                table: "SubOpcionLlamada",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoriaLlamadaId",
                table: "OpcionLlamada",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LlamadaId",
                table: "OpcionLlamada",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "InformacionCliente",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CambioEstadoId",
                table: "Estado",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LlamadaId",
                table: "Cliente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "LlamadaId",
                table: "CambioEstado",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OpcionLlamada_LlamadaId",
                table: "OpcionLlamada",
                column: "LlamadaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Estado_CambioEstadoId",
                table: "Estado",
                column: "CambioEstadoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_LlamadaId",
                table: "Cliente",
                column: "LlamadaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CambioEstado_Llamadas_LlamadaId",
                table: "CambioEstado",
                column: "LlamadaId",
                principalTable: "Llamadas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "FK_OpcionLlamada_Llamadas_LlamadaId",
                table: "OpcionLlamada");

            migrationBuilder.DropForeignKey(
                name: "FK_SubOpcionLlamada_OpcionLlamada_opcionLlamadaId",
                table: "SubOpcionLlamada");

            migrationBuilder.DropForeignKey(
                name: "FK_Validacion_OpcionLlamada_opcionLlamadaId",
                table: "Validacion");

            migrationBuilder.DropIndex(
                name: "IX_OpcionLlamada_LlamadaId",
                table: "OpcionLlamada");

            migrationBuilder.DropIndex(
                name: "IX_Estado_CambioEstadoId",
                table: "Estado");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_LlamadaId",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "CategoriaLlamadaId",
                table: "OpcionLlamada");

            migrationBuilder.DropColumn(
                name: "LlamadaId",
                table: "OpcionLlamada");

            migrationBuilder.DropColumn(
                name: "CambioEstadoId",
                table: "Estado");

            migrationBuilder.DropColumn(
                name: "LlamadaId",
                table: "Cliente");

            migrationBuilder.RenameColumn(
                name: "opcionLlamadaId",
                table: "Validacion",
                newName: "OpcionLlamadaId");

            migrationBuilder.RenameIndex(
                name: "IX_Validacion_opcionLlamadaId",
                table: "Validacion",
                newName: "IX_Validacion_OpcionLlamadaId");

            migrationBuilder.RenameColumn(
                name: "opcionLlamadaId",
                table: "SubOpcionLlamada",
                newName: "OpcionLlamadaId");

            migrationBuilder.RenameIndex(
                name: "IX_SubOpcionLlamada_opcionLlamadaId",
                table: "SubOpcionLlamada",
                newName: "IX_SubOpcionLlamada_OpcionLlamadaId");

            migrationBuilder.AlterColumn<int>(
                name: "OpcionLlamadaId",
                table: "Validacion",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OpcionLlamadaId",
                table: "SubOpcionLlamada",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Llamadas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OpcionLlamadaId",
                table: "Llamadas",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "InformacionCliente",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "LlamadaId",
                table: "CambioEstado",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "EstadoId",
                table: "CambioEstado",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Llamadas_ClienteId",
                table: "Llamadas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Llamadas_OpcionLlamadaId",
                table: "Llamadas",
                column: "OpcionLlamadaId");

            migrationBuilder.CreateIndex(
                name: "IX_CambioEstado_EstadoId",
                table: "CambioEstado",
                column: "EstadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_CambioEstado_Estado_EstadoId",
                table: "CambioEstado",
                column: "EstadoId",
                principalTable: "Estado",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CambioEstado_Llamadas_LlamadaId",
                table: "CambioEstado",
                column: "LlamadaId",
                principalTable: "Llamadas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InformacionCliente_Cliente_ClienteId",
                table: "InformacionCliente",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Llamadas_Cliente_ClienteId",
                table: "Llamadas",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Llamadas_OpcionLlamada_OpcionLlamadaId",
                table: "Llamadas",
                column: "OpcionLlamadaId",
                principalTable: "OpcionLlamada",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubOpcionLlamada_OpcionLlamada_OpcionLlamadaId",
                table: "SubOpcionLlamada",
                column: "OpcionLlamadaId",
                principalTable: "OpcionLlamada",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Validacion_OpcionLlamada_OpcionLlamadaId",
                table: "Validacion",
                column: "OpcionLlamadaId",
                principalTable: "OpcionLlamada",
                principalColumn: "Id");
        }
    }
}
