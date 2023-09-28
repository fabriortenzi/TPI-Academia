using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TPI.Datos.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "especialidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_especialidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "personas",
                columns: table => new
                {
                    Dni = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personas", x => x.Dni);
                });

            migrationBuilder.CreateTable(
                name: "tipos_de_usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipos_de_usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "comisiones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NroComision = table.Column<int>(type: "int", nullable: false),
                    EspecialidadId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comisiones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_comisiones_especialidades_EspecialidadId",
                        column: x => x.EspecialidadId,
                        principalTable: "especialidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "planes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Anio = table.Column<int>(type: "int", nullable: false),
                    EspecialidadId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_planes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_planes_especialidades_EspecialidadId",
                        column: x => x.EspecialidadId,
                        principalTable: "especialidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "materias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanId = table.Column<int>(type: "int", nullable: true),
                    HorasSemanales = table.Column<int>(type: "int", nullable: false),
                    HorasTotales = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_materias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_materias_planes_PlanId",
                        column: x => x.PlanId,
                        principalTable: "planes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    Legajo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonaDni = table.Column<int>(type: "int", nullable: true),
                    TipoDeUsuarioId = table.Column<int>(type: "int", nullable: true),
                    PlanId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.Legajo);
                    table.ForeignKey(
                        name: "FK_usuarios_personas_PersonaDni",
                        column: x => x.PersonaDni,
                        principalTable: "personas",
                        principalColumn: "Dni",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_usuarios_planes_PlanId",
                        column: x => x.PlanId,
                        principalTable: "planes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_usuarios_tipos_de_usuario_TipoDeUsuarioId",
                        column: x => x.TipoDeUsuarioId,
                        principalTable: "tipos_de_usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cursos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CicloLectivo = table.Column<int>(type: "int", nullable: false),
                    MateriaId = table.Column<int>(type: "int", nullable: true),
                    ComisionId = table.Column<int>(type: "int", nullable: true),
                    Cupo = table.Column<int>(type: "int", nullable: false),
                    Dia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoraInicio = table.Column<TimeSpan>(type: "time", nullable: false),
                    HoraFin = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cursos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cursos_comisiones_ComisionId",
                        column: x => x.ComisionId,
                        principalTable: "comisiones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cursos_materias_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "materias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cursados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioLegajo = table.Column<int>(type: "int", nullable: true),
                    CursoId = table.Column<int>(type: "int", nullable: true),
                    FechaHoraInscripcion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NotaFinal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cursados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cursados_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cursados_usuarios_UsuarioLegajo",
                        column: x => x.UsuarioLegajo,
                        principalTable: "usuarios",
                        principalColumn: "Legajo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "profesores_cursos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioLegajo = table.Column<int>(type: "int", nullable: true),
                    CursoId = table.Column<int>(type: "int", nullable: true),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profesores_cursos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_profesores_cursos_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_profesores_cursos_usuarios_UsuarioLegajo",
                        column: x => x.UsuarioLegajo,
                        principalTable: "usuarios",
                        principalColumn: "Legajo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_comisiones_EspecialidadId",
                table: "comisiones",
                column: "EspecialidadId");

            migrationBuilder.CreateIndex(
                name: "IX_cursados_CursoId",
                table: "cursados",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_cursados_UsuarioLegajo",
                table: "cursados",
                column: "UsuarioLegajo");

            migrationBuilder.CreateIndex(
                name: "IX_cursos_ComisionId",
                table: "cursos",
                column: "ComisionId");

            migrationBuilder.CreateIndex(
                name: "IX_cursos_MateriaId",
                table: "cursos",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_materias_PlanId",
                table: "materias",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_planes_EspecialidadId",
                table: "planes",
                column: "EspecialidadId");

            migrationBuilder.CreateIndex(
                name: "IX_profesores_cursos_CursoId",
                table: "profesores_cursos",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_profesores_cursos_UsuarioLegajo",
                table: "profesores_cursos",
                column: "UsuarioLegajo");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_PersonaDni",
                table: "usuarios",
                column: "PersonaDni");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_PlanId",
                table: "usuarios",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_TipoDeUsuarioId",
                table: "usuarios",
                column: "TipoDeUsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cursados");

            migrationBuilder.DropTable(
                name: "profesores_cursos");

            migrationBuilder.DropTable(
                name: "cursos");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "comisiones");

            migrationBuilder.DropTable(
                name: "materias");

            migrationBuilder.DropTable(
                name: "personas");

            migrationBuilder.DropTable(
                name: "tipos_de_usuario");

            migrationBuilder.DropTable(
                name: "planes");

            migrationBuilder.DropTable(
                name: "especialidades");
        }
    }
}
