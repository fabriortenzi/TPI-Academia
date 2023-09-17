﻿// <auto-generated />
using System;
using AcademiaWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AcademiaWeb.Migrations
{
    [DbContext(typeof(AcademiaWebContext))]
    [Migration("20230915232956_Plan-Usuario3")]
    partial class PlanUsuario3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AcademiaWeb.Models.Persona", b =>
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

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("AcademiaWeb.Models.Plan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Anio")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Plan");
                });

            modelBuilder.Entity("AcademiaWeb.Models.TipoDeUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoDeUsuario");
                });

            modelBuilder.Entity("AcademiaWeb.Models.Usuario", b =>
                {
                    b.Property<int>("Legajo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonaDni")
                        .HasColumnType("int");

                    b.Property<int?>("PlanId")
                        .HasColumnType("int");

                    b.Property<int?>("TipoDeUsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Legajo");

                    b.HasIndex("PersonaDni");

                    b.HasIndex("PlanId");

                    b.HasIndex("TipoDeUsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("AcademiaWeb.Models.Usuario", b =>
                {
                    b.HasOne("AcademiaWeb.Models.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaDni");

                    b.HasOne("AcademiaWeb.Models.Plan", "Plan")
                        .WithMany()
                        .HasForeignKey("PlanId");

                    b.HasOne("AcademiaWeb.Models.TipoDeUsuario", "TipoDeUsuario")
                        .WithMany()
                        .HasForeignKey("TipoDeUsuarioId");

                    b.Navigation("Persona");

                    b.Navigation("Plan");

                    b.Navigation("TipoDeUsuario");
                });
#pragma warning restore 612, 618
        }
    }
}
