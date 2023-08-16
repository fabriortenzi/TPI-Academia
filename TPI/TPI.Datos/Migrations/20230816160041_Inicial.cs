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
                    idEspec = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descEspec = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_especialidades", x => x.idEspec);
                });

            migrationBuilder.CreateTable(
                name: "modulos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ejecuta = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modulos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "personas",
                columns: table => new
                {
                    Dni = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    IdCom = table.Column<int>(type: "int", nullable: false),
                    IdEspecialidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comisiones", x => new { x.IdCom, x.IdEspecialidad });
                    table.ForeignKey(
                        name: "FK_comisiones_especialidades_IdEspecialidad",
                        column: x => x.IdEspecialidad,
                        principalTable: "especialidades",
                        principalColumn: "idEspec",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "planes",
                columns: table => new
                {
                    IdEspecialidad = table.Column<int>(type: "int", nullable: false),
                    anio = table.Column<int>(type: "int", nullable: false),
                    descPlan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_planes", x => new { x.IdEspecialidad, x.anio });
                    table.ForeignKey(
                        name: "FK_planes_especialidades_IdEspecialidad",
                        column: x => x.IdEspecialidad,
                        principalTable: "especialidades",
                        principalColumn: "idEspec",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "modulos_usuarios",
                columns: table => new
                {
                    IdModulo = table.Column<int>(type: "int", nullable: false),
                    IdTipoDeUsuario = table.Column<int>(type: "int", nullable: false),
                    Alta = table.Column<bool>(type: "bit", nullable: false),
                    Baja = table.Column<bool>(type: "bit", nullable: false),
                    Modificacion = table.Column<bool>(type: "bit", nullable: false),
                    Consulta = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modulos_usuarios", x => new { x.IdModulo, x.IdTipoDeUsuario });
                    table.ForeignKey(
                        name: "FK_modulos_usuarios_modulos_IdModulo",
                        column: x => x.IdModulo,
                        principalTable: "modulos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_modulos_usuarios_tipos_de_usuario_IdTipoDeUsuario",
                        column: x => x.IdTipoDeUsuario,
                        principalTable: "tipos_de_usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "materias",
                columns: table => new
                {
                    idMateria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEspecialidad = table.Column<int>(type: "int", nullable: false),
                    anio = table.Column<int>(type: "int", nullable: false),
                    descMateria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    horaSem = table.Column<int>(type: "int", nullable: false),
                    horaTot = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_materias", x => x.idMateria);
                    table.ForeignKey(
                        name: "FK_materias_planes_IdEspecialidad_anio",
                        columns: x => new { x.IdEspecialidad, x.anio },
                        principalTable: "planes",
                        principalColumns: new[] { "IdEspecialidad", "anio" },
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
                    PlanIdEspecialidad = table.Column<int>(type: "int", nullable: true),
                    Plananio = table.Column<int>(type: "int", nullable: true)
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
                        name: "FK_usuarios_planes_PlanIdEspecialidad_Plananio",
                        columns: x => new { x.PlanIdEspecialidad, x.Plananio },
                        principalTable: "planes",
                        principalColumns: new[] { "IdEspecialidad", "anio" },
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
                    IdMateria = table.Column<int>(type: "int", nullable: false),
                    Año = table.Column<int>(type: "int", nullable: false),
                    Cupo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cursos", x => new { x.IdMateria, x.Año });
                    table.ForeignKey(
                        name: "FK_cursos_materias_IdMateria",
                        column: x => x.IdMateria,
                        principalTable: "materias",
                        principalColumn: "idMateria",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "inscripciones_cursados",
                columns: table => new
                {
                    LegajoUsuario = table.Column<int>(type: "int", nullable: false),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdMateria = table.Column<int>(type: "int", nullable: false),
                    AñoCurso = table.Column<int>(type: "int", nullable: false),
                    IdComision = table.Column<int>(type: "int", nullable: false),
                    IdEspecialidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inscripciones_cursados", x => new { x.LegajoUsuario, x.FechaHora });
                    table.ForeignKey(
                        name: "FK_inscripciones_cursados_comisiones_IdComision_IdEspecialidad",
                        columns: x => new { x.IdComision, x.IdEspecialidad },
                        principalTable: "comisiones",
                        principalColumns: new[] { "IdCom", "IdEspecialidad" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_inscripciones_cursados_cursos_IdMateria_AñoCurso",
                        columns: x => new { x.IdMateria, x.AñoCurso },
                        principalTable: "cursos",
                        principalColumns: new[] { "IdMateria", "Año" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_inscripciones_cursados_usuarios_LegajoUsuario",
                        column: x => x.LegajoUsuario,
                        principalTable: "usuarios",
                        principalColumn: "Legajo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_comisiones_IdEspecialidad",
                table: "comisiones",
                column: "IdEspecialidad");

            migrationBuilder.CreateIndex(
                name: "IX_inscripciones_cursados_IdComision_IdEspecialidad",
                table: "inscripciones_cursados",
                columns: new[] { "IdComision", "IdEspecialidad" });

            migrationBuilder.CreateIndex(
                name: "IX_inscripciones_cursados_IdMateria_AñoCurso",
                table: "inscripciones_cursados",
                columns: new[] { "IdMateria", "AñoCurso" });

            migrationBuilder.CreateIndex(
                name: "IX_materias_IdEspecialidad_anio",
                table: "materias",
                columns: new[] { "IdEspecialidad", "anio" });

            migrationBuilder.CreateIndex(
                name: "IX_modulos_usuarios_IdTipoDeUsuario",
                table: "modulos_usuarios",
                column: "IdTipoDeUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_PersonaDni",
                table: "usuarios",
                column: "PersonaDni");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_PlanIdEspecialidad_Plananio",
                table: "usuarios",
                columns: new[] { "PlanIdEspecialidad", "Plananio" });

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_TipoDeUsuarioId",
                table: "usuarios",
                column: "TipoDeUsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "inscripciones_cursados");

            migrationBuilder.DropTable(
                name: "modulos_usuarios");

            migrationBuilder.DropTable(
                name: "comisiones");

            migrationBuilder.DropTable(
                name: "cursos");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "modulos");

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
