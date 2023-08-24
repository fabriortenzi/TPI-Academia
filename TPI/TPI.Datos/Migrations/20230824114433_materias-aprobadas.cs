using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TPI.Datos.Migrations
{
    public partial class materiasaprobadas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "evaluaciones",
                columns: table => new
                {
                    idEvaluacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LegajoUsuario = table.Column<int>(type: "int", nullable: false),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nota = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_evaluaciones", x => x.idEvaluacion);
                    table.ForeignKey(
                        name: "FK_evaluaciones_inscripciones_cursados_LegajoUsuario_FechaHora",
                        columns: x => new { x.LegajoUsuario, x.FechaHora },
                        principalTable: "inscripciones_cursados",
                        principalColumns: new[] { "LegajoUsuario", "FechaHora" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "materias_aprobadas",
                columns: table => new
                {
                    Legajo = table.Column<int>(type: "int", nullable: false),
                    idMateria = table.Column<int>(type: "int", nullable: false),
                    Nota = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_materias_aprobadas", x => new { x.idMateria, x.Legajo });
                    table.ForeignKey(
                        name: "FK_materias_aprobadas_materias_idMateria",
                        column: x => x.idMateria,
                        principalTable: "materias",
                        principalColumn: "idMateria",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_materias_aprobadas_usuarios_Legajo",
                        column: x => x.Legajo,
                        principalTable: "usuarios",
                        principalColumn: "Legajo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "materias_comisiones",
                columns: table => new
                {
                    idMateria = table.Column<int>(type: "int", nullable: false),
                    IdEspecialidad = table.Column<int>(type: "int", nullable: false),
                    IdCom = table.Column<int>(type: "int", nullable: false),
                    Cupo = table.Column<int>(type: "int", nullable: false),
                    dia = table.Column<int>(type: "int", nullable: false),
                    hora_ini = table.Column<TimeSpan>(type: "time", nullable: false),
                    hora_fin = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_materias_comisiones", x => new { x.idMateria, x.IdEspecialidad, x.IdCom });
                    table.ForeignKey(
                        name: "FK_materias_comisiones_comisiones_IdCom_IdEspecialidad",
                        columns: x => new { x.IdCom, x.IdEspecialidad },
                        principalTable: "comisiones",
                        principalColumns: new[] { "IdCom", "IdEspecialidad" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_materias_comisiones_materias_idMateria",
                        column: x => x.idMateria,
                        principalTable: "materias",
                        principalColumn: "idMateria",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "profesores_cursos",
                columns: table => new
                {
                    Legajo = table.Column<int>(type: "int", nullable: false),
                    idMateria = table.Column<int>(type: "int", nullable: false),
                    Anio = table.Column<int>(type: "int", nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profesores_cursos", x => new { x.idMateria, x.Legajo, x.Anio });
                    table.ForeignKey(
                        name: "FK_profesores_cursos_cursos_idMateria_Anio",
                        columns: x => new { x.idMateria, x.Anio },
                        principalTable: "cursos",
                        principalColumns: new[] { "IdMateria", "Año" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_profesores_cursos_usuarios_Legajo",
                        column: x => x.Legajo,
                        principalTable: "usuarios",
                        principalColumn: "Legajo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_evaluaciones_LegajoUsuario_FechaHora",
                table: "evaluaciones",
                columns: new[] { "LegajoUsuario", "FechaHora" });

            migrationBuilder.CreateIndex(
                name: "IX_materias_aprobadas_Legajo",
                table: "materias_aprobadas",
                column: "Legajo");

            migrationBuilder.CreateIndex(
                name: "IX_materias_comisiones_IdCom_IdEspecialidad",
                table: "materias_comisiones",
                columns: new[] { "IdCom", "IdEspecialidad" });

            migrationBuilder.CreateIndex(
                name: "IX_profesores_cursos_idMateria_Anio",
                table: "profesores_cursos",
                columns: new[] { "idMateria", "Anio" });

            migrationBuilder.CreateIndex(
                name: "IX_profesores_cursos_Legajo",
                table: "profesores_cursos",
                column: "Legajo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "evaluaciones");

            migrationBuilder.DropTable(
                name: "materias_aprobadas");

            migrationBuilder.DropTable(
                name: "materias_comisiones");

            migrationBuilder.DropTable(
                name: "profesores_cursos");
        }
    }
}
