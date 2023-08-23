using Microsoft.EntityFrameworkCore.Migrations;

namespace TPI.Datos.Migrations
{
    public partial class MTIV9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_materias_comisiones_comisiones_IdCom_IdEspecialidad",
                table: "materias_comisiones");

            migrationBuilder.RenameColumn(
                name: "IdEspecialidad",
                table: "materias_comisiones",
                newName: "idEspecialidad");

            migrationBuilder.RenameIndex(
                name: "IX_materias_comisiones_IdCom_IdEspecialidad",
                table: "materias_comisiones",
                newName: "IX_materias_comisiones_IdCom_idEspecialidad");

            migrationBuilder.AddForeignKey(
                name: "FK_materias_comisiones_comisiones_IdCom_idEspecialidad",
                table: "materias_comisiones",
                columns: new[] { "IdCom", "idEspecialidad" },
                principalTable: "comisiones",
                principalColumns: new[] { "IdCom", "IdEspecialidad" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_materias_comisiones_comisiones_IdCom_idEspecialidad",
                table: "materias_comisiones");

            migrationBuilder.RenameColumn(
                name: "idEspecialidad",
                table: "materias_comisiones",
                newName: "IdEspecialidad");

            migrationBuilder.RenameIndex(
                name: "IX_materias_comisiones_IdCom_idEspecialidad",
                table: "materias_comisiones",
                newName: "IX_materias_comisiones_IdCom_IdEspecialidad");

            migrationBuilder.AddForeignKey(
                name: "FK_materias_comisiones_comisiones_IdCom_IdEspecialidad",
                table: "materias_comisiones",
                columns: new[] { "IdCom", "IdEspecialidad" },
                principalTable: "comisiones",
                principalColumns: new[] { "IdCom", "IdEspecialidad" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
