using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PPAI_IVR.Migrations
{
    /// <inheritdoc />
    public partial class correccion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Llamadas_LlamadaId",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_LlamadaId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "LlamadaId",
                table: "Clientes");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Llamadas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Llamadas_ClienteId",
                table: "Llamadas",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Llamadas_Clientes_ClienteId",
                table: "Llamadas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Llamadas_Clientes_ClienteId",
                table: "Llamadas");

            migrationBuilder.DropIndex(
                name: "IX_Llamadas_ClienteId",
                table: "Llamadas");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Llamadas");

            migrationBuilder.AddColumn<int>(
                name: "LlamadaId",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_LlamadaId",
                table: "Clientes",
                column: "LlamadaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Llamadas_LlamadaId",
                table: "Clientes",
                column: "LlamadaId",
                principalTable: "Llamadas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
