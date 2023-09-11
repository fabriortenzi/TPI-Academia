using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TPI.Datos.Migrations
{
    public partial class Redefinicion_InscripcionCursado_Evaluacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_evaluaciones_inscripciones_cursados_LegajoUsuario_FechaHora",
                table: "evaluaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_inscripciones_cursados",
                table: "inscripciones_cursados");

            migrationBuilder.DropIndex(
                name: "IX_evaluaciones_LegajoUsuario_FechaHora",
                table: "evaluaciones");

            migrationBuilder.DropColumn(
                name: "FechaHora",
                table: "evaluaciones");

            migrationBuilder.RenameColumn(
                name: "LegajoUsuario",
                table: "evaluaciones",
                newName: "IdInscripcion");

            migrationBuilder.RenameColumn(
                name: "idEvaluacion",
                table: "evaluaciones",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "inscripciones_cursados",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_inscripciones_cursados",
                table: "inscripciones_cursados",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_inscripciones_cursados_LegajoUsuario",
                table: "inscripciones_cursados",
                column: "LegajoUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_evaluaciones_IdInscripcion",
                table: "evaluaciones",
                column: "IdInscripcion");

            migrationBuilder.AddForeignKey(
                name: "FK_evaluaciones_inscripciones_cursados_IdInscripcion",
                table: "evaluaciones",
                column: "IdInscripcion",
                principalTable: "inscripciones_cursados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_evaluaciones_inscripciones_cursados_IdInscripcion",
                table: "evaluaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_inscripciones_cursados",
                table: "inscripciones_cursados");

            migrationBuilder.DropIndex(
                name: "IX_inscripciones_cursados_LegajoUsuario",
                table: "inscripciones_cursados");

            migrationBuilder.DropIndex(
                name: "IX_evaluaciones_IdInscripcion",
                table: "evaluaciones");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "inscripciones_cursados");

            migrationBuilder.RenameColumn(
                name: "IdInscripcion",
                table: "evaluaciones",
                newName: "LegajoUsuario");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "evaluaciones",
                newName: "idEvaluacion");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaHora",
                table: "evaluaciones",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_inscripciones_cursados",
                table: "inscripciones_cursados",
                columns: new[] { "LegajoUsuario", "FechaHora" });

            migrationBuilder.CreateIndex(
                name: "IX_evaluaciones_LegajoUsuario_FechaHora",
                table: "evaluaciones",
                columns: new[] { "LegajoUsuario", "FechaHora" });

            migrationBuilder.AddForeignKey(
                name: "FK_evaluaciones_inscripciones_cursados_LegajoUsuario_FechaHora",
                table: "evaluaciones",
                columns: new[] { "LegajoUsuario", "FechaHora" },
                principalTable: "inscripciones_cursados",
                principalColumns: new[] { "LegajoUsuario", "FechaHora" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
