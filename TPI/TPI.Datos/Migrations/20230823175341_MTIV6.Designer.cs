﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TPI.Datos;

namespace TPI.Datos.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230823175341_MTIV6")]
    partial class MTIV6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TPI.Entidades.Comisiones", b =>
                {
                    b.Property<int>("IdCom")
                        .HasColumnType("int");

                    b.Property<int>("IdEspecialidad")
                        .HasColumnType("int");

                    b.HasKey("IdCom", "IdEspecialidad");

                    b.HasIndex("IdEspecialidad");

                    b.ToTable("comisiones");
                });

            modelBuilder.Entity("TPI.Entidades.Curso", b =>
                {
                    b.Property<int>("IdMateria")
                        .HasColumnType("int");

                    b.Property<int>("Año")
                        .HasColumnType("int");

                    b.Property<int>("Cupo")
                        .HasColumnType("int");

                    b.HasKey("IdMateria", "Año");

                    b.ToTable("cursos");
                });

            modelBuilder.Entity("TPI.Entidades.Especialidad", b =>
                {
                    b.Property<int>("idEspec")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descEspec")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idEspec");

                    b.ToTable("especialidades");
                });

            modelBuilder.Entity("TPI.Entidades.Evaluacion", b =>
                {
                    b.Property<int>("idEvaluacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<int>("LegajoUsuario")
                        .HasColumnType("int");

                    b.Property<int>("Nota")
                        .HasColumnType("int");

                    b.HasKey("idEvaluacion");

                    b.HasIndex("LegajoUsuario", "FechaHora");

                    b.ToTable("evaluaciones");
                });

            modelBuilder.Entity("TPI.Entidades.InscripcionCursado", b =>
                {
                    b.Property<int>("LegajoUsuario")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<int>("AñoCurso")
                        .HasColumnType("int");

                    b.Property<int>("IdComision")
                        .HasColumnType("int");

                    b.Property<int>("IdEspecialidad")
                        .HasColumnType("int");

                    b.Property<int>("IdMateria")
                        .HasColumnType("int");

                    b.HasKey("LegajoUsuario", "FechaHora");

                    b.HasIndex("IdComision", "IdEspecialidad");

                    b.HasIndex("IdMateria", "AñoCurso");

                    b.ToTable("inscripciones_cursados");
                });

            modelBuilder.Entity("TPI.Entidades.Materia", b =>
                {
                    b.Property<int>("idMateria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdEspecialidad")
                        .HasColumnType("int");

                    b.Property<int>("anio")
                        .HasColumnType("int");

                    b.Property<string>("descMateria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("horaSem")
                        .HasColumnType("int");

                    b.Property<int>("horaTot")
                        .HasColumnType("int");

                    b.HasKey("idMateria");

                    b.HasIndex("IdEspecialidad", "anio");

                    b.ToTable("materias");
                });

            modelBuilder.Entity("TPI.Entidades.MateriaAprobada", b =>
                {
                    b.Property<int>("idMateria")
                        .HasColumnType("int");

                    b.Property<int>("Legajo")
                        .HasColumnType("int");

                    b.Property<int>("Nota")
                        .HasColumnType("int");

                    b.HasKey("idMateria", "Legajo");

                    b.HasIndex("Legajo");

                    b.ToTable("materias_aprobadas");
                });

            modelBuilder.Entity("TPI.Entidades.MateriaComision", b =>
                {
                    b.Property<int>("idMateria")
                        .HasColumnType("int");

                    b.Property<int>("IdEspecialidad")
                        .HasColumnType("int");

                    b.Property<int>("IdCom")
                        .HasColumnType("int");

                    b.Property<int>("Cupo")
                        .HasColumnType("int");

                    b.Property<int>("dia")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("hora_fin")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("hora_ini")
                        .HasColumnType("time");

                    b.HasKey("idMateria", "IdEspecialidad", "IdCom");

                    b.HasIndex("IdCom", "IdEspecialidad");

                    b.ToTable("materias_comisiones");
                });

            modelBuilder.Entity("TPI.Entidades.Modulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ejecuta")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("modulos");
                });

            modelBuilder.Entity("TPI.Entidades.ModuloUsuario", b =>
                {
                    b.Property<int>("IdModulo")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoDeUsuario")
                        .HasColumnType("int");

                    b.Property<bool>("Alta")
                        .HasColumnType("bit");

                    b.Property<bool>("Baja")
                        .HasColumnType("bit");

                    b.Property<bool>("Consulta")
                        .HasColumnType("bit");

                    b.Property<bool>("Modificacion")
                        .HasColumnType("bit");

                    b.HasKey("IdModulo", "IdTipoDeUsuario");

                    b.HasIndex("IdTipoDeUsuario");

                    b.ToTable("modulos_usuarios");
                });

            modelBuilder.Entity("TPI.Entidades.Persona", b =>
                {
                    b.Property<int>("Dni")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Dni");

                    b.ToTable("personas");
                });

            modelBuilder.Entity("TPI.Entidades.Plan", b =>
                {
                    b.Property<int>("IdEspecialidad")
                        .HasColumnType("int");

                    b.Property<int>("anio")
                        .HasColumnType("int");

                    b.Property<string>("descPlan")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEspecialidad", "anio");

                    b.ToTable("planes");
                });

            modelBuilder.Entity("TPI.Entidades.ProfesorCurso", b =>
                {
                    b.Property<int>("idMateria")
                        .HasColumnType("int");

                    b.Property<int>("Legajo")
                        .HasColumnType("int");

                    b.Property<int>("Anio")
                        .HasColumnType("int");

                    b.Property<string>("Cargo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idMateria", "Legajo", "Anio");

                    b.HasIndex("Legajo");

                    b.HasIndex("idMateria", "Anio");

                    b.ToTable("profesores_cursos");
                });

            modelBuilder.Entity("TPI.Entidades.TipoDeUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tipos_de_usuario");
                });

            modelBuilder.Entity("TPI.Entidades.Usuario", b =>
                {
                    b.Property<int>("Legajo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonaDni")
                        .HasColumnType("int");

                    b.Property<int?>("PlanIdEspecialidad")
                        .HasColumnType("int");

                    b.Property<int?>("Plananio")
                        .HasColumnType("int");

                    b.Property<int?>("TipoDeUsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Legajo");

                    b.HasIndex("PersonaDni");

                    b.HasIndex("TipoDeUsuarioId");

                    b.HasIndex("PlanIdEspecialidad", "Plananio");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("TPI.Entidades.Comisiones", b =>
                {
                    b.HasOne("TPI.Entidades.Especialidad", "Especialidad")
                        .WithMany()
                        .HasForeignKey("IdEspecialidad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Especialidad");
                });

            modelBuilder.Entity("TPI.Entidades.Curso", b =>
                {
                    b.HasOne("TPI.Entidades.Materia", "Materia")
                        .WithMany()
                        .HasForeignKey("IdMateria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Materia");
                });

            modelBuilder.Entity("TPI.Entidades.Evaluacion", b =>
                {
                    b.HasOne("TPI.Entidades.InscripcionCursado", "InscripcionCursado")
                        .WithMany()
                        .HasForeignKey("LegajoUsuario", "FechaHora")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InscripcionCursado");
                });

            modelBuilder.Entity("TPI.Entidades.InscripcionCursado", b =>
                {
                    b.HasOne("TPI.Entidades.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("LegajoUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TPI.Entidades.Comisiones", "Comision")
                        .WithMany()
                        .HasForeignKey("IdComision", "IdEspecialidad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TPI.Entidades.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("IdMateria", "AñoCurso")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comision");

                    b.Navigation("Curso");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("TPI.Entidades.Materia", b =>
                {
                    b.HasOne("TPI.Entidades.Plan", "Plan")
                        .WithMany()
                        .HasForeignKey("IdEspecialidad", "anio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plan");
                });

            modelBuilder.Entity("TPI.Entidades.MateriaAprobada", b =>
                {
                    b.HasOne("TPI.Entidades.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("Legajo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TPI.Entidades.Materia", "Materia")
                        .WithMany()
                        .HasForeignKey("idMateria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Materia");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("TPI.Entidades.MateriaComision", b =>
                {
                    b.HasOne("TPI.Entidades.Materia", "Materia")
                        .WithMany()
                        .HasForeignKey("idMateria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TPI.Entidades.Comisiones", "Comisiones")
                        .WithMany()
                        .HasForeignKey("IdCom", "IdEspecialidad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comisiones");

                    b.Navigation("Materia");
                });

            modelBuilder.Entity("TPI.Entidades.ModuloUsuario", b =>
                {
                    b.HasOne("TPI.Entidades.Modulo", "Modulo")
                        .WithMany()
                        .HasForeignKey("IdModulo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TPI.Entidades.TipoDeUsuario", "TipoDeUsuario")
                        .WithMany()
                        .HasForeignKey("IdTipoDeUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Modulo");

                    b.Navigation("TipoDeUsuario");
                });

            modelBuilder.Entity("TPI.Entidades.Plan", b =>
                {
                    b.HasOne("TPI.Entidades.Especialidad", "especialidad")
                        .WithMany()
                        .HasForeignKey("IdEspecialidad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("especialidad");
                });

            modelBuilder.Entity("TPI.Entidades.ProfesorCurso", b =>
                {
                    b.HasOne("TPI.Entidades.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("Legajo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TPI.Entidades.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("idMateria", "Anio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("TPI.Entidades.Usuario", b =>
                {
                    b.HasOne("TPI.Entidades.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaDni");

                    b.HasOne("TPI.Entidades.TipoDeUsuario", "TipoDeUsuario")
                        .WithMany()
                        .HasForeignKey("TipoDeUsuarioId");

                    b.HasOne("TPI.Entidades.Plan", "Plan")
                        .WithMany()
                        .HasForeignKey("PlanIdEspecialidad", "Plananio");

                    b.Navigation("Persona");

                    b.Navigation("Plan");

                    b.Navigation("TipoDeUsuario");
                });
#pragma warning restore 612, 618
        }
    }
}
