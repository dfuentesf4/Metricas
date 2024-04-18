using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Metricas.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Estudiantes_EstudianteId",
                table: "Pagos");

            migrationBuilder.DropIndex(
                name: "IX_Pagos_EstudianteId",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "EstudianteId",
                table: "Pagos");

            migrationBuilder.AddColumn<int>(
                name: "PagoId",
                table: "Estudiantes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_PagoId",
                table: "Estudiantes",
                column: "PagoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiantes_Pagos_PagoId",
                table: "Estudiantes",
                column: "PagoId",
                principalTable: "Pagos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estudiantes_Pagos_PagoId",
                table: "Estudiantes");

            migrationBuilder.DropIndex(
                name: "IX_Estudiantes_PagoId",
                table: "Estudiantes");

            migrationBuilder.DropColumn(
                name: "PagoId",
                table: "Estudiantes");

            migrationBuilder.AddColumn<int>(
                name: "EstudianteId",
                table: "Pagos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_EstudianteId",
                table: "Pagos",
                column: "EstudianteId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Estudiantes_EstudianteId",
                table: "Pagos",
                column: "EstudianteId",
                principalTable: "Estudiantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
