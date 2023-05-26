using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PPAI_IVR.Migrations
{
    /// <inheritdoc />
    public partial class baseCompleta3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CambioEstado_Llamadas_LlamadaId",
                table: "CambioEstado");

            migrationBuilder.AlterColumn<int>(
                name: "LlamadaId",
                table: "CambioEstado",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_CambioEstado_Llamadas_LlamadaId",
                table: "CambioEstado",
                column: "LlamadaId",
                principalTable: "Llamadas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CambioEstado_Llamadas_LlamadaId",
                table: "CambioEstado");

            migrationBuilder.AlterColumn<int>(
                name: "LlamadaId",
                table: "CambioEstado",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CambioEstado_Llamadas_LlamadaId",
                table: "CambioEstado",
                column: "LlamadaId",
                principalTable: "Llamadas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
