﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PPAI_IVR;

#nullable disable

namespace PPAI_IVR.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230526032525_baseCompleta4")]
    partial class baseCompleta4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PPAI_IVR.Clases.CambioEstado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("FechaHoraInicio")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LlamadaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LlamadaId");

                    b.ToTable("CambiosDeEstado");
                });

            modelBuilder.Entity("PPAI_IVR.Clases.CategoriaLlamada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("audioMensajeOpciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mensajeOpciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("nroOrden")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CategoriaLlamadas");
                });

            modelBuilder.Entity("PPAI_IVR.Clases.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("LlamadaId")
                        .HasColumnType("int");

                    b.Property<string>("NombreCompleto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("nroCelular")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LlamadaId")
                        .IsUnique();

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("PPAI_IVR.Clases.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CambioEstadoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CambioEstadoId")
                        .IsUnique();

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("PPAI_IVR.Clases.InformacionCliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int?>("ValidacionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("datoAValidar")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ValidacionId");

                    b.ToTable("InformacionClientes");
                });

            modelBuilder.Entity("PPAI_IVR.Clases.Llamada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DescripcionOperador")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DetalleAccionRequerida")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Duracion")
                        .HasColumnType("float");

                    b.Property<bool>("EncuestaEnviada")
                        .HasColumnType("bit");

                    b.Property<string>("ObservacionAuditor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Llamadas");
                });

            modelBuilder.Entity("PPAI_IVR.Clases.OpcionLlamada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoriaLlamadaId")
                        .HasColumnType("int");

                    b.Property<int>("LlamadaId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NroOrden")
                        .HasColumnType("int");

                    b.Property<string>("audioMensajeSubOpciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mensajeSubOpcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LlamadaId")
                        .IsUnique();

                    b.ToTable("OpcionLlamadas");
                });

            modelBuilder.Entity("PPAI_IVR.Clases.SubOpcionLlamada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("nroOrden")
                        .HasColumnType("int");

                    b.Property<int>("opcionLlamadaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("opcionLlamadaId");

                    b.ToTable("SubOpcionLlamadas");
                });

            modelBuilder.Entity("PPAI_IVR.Clases.Validacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("audioMensajeValidacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("opcionLlamadaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("opcionLlamadaId");

                    b.ToTable("ValidacionClientes");
                });

            modelBuilder.Entity("PPAI_IVR.Clases.CambioEstado", b =>
                {
                    b.HasOne("PPAI_IVR.Clases.Llamada", null)
                        .WithMany("CambiosDeEstados")
                        .HasForeignKey("LlamadaId");
                });

            modelBuilder.Entity("PPAI_IVR.Clases.Cliente", b =>
                {
                    b.HasOne("PPAI_IVR.Clases.Llamada", null)
                        .WithOne("Cliente")
                        .HasForeignKey("PPAI_IVR.Clases.Cliente", "LlamadaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PPAI_IVR.Clases.Estado", b =>
                {
                    b.HasOne("PPAI_IVR.Clases.CambioEstado", null)
                        .WithOne("Estado")
                        .HasForeignKey("PPAI_IVR.Clases.Estado", "CambioEstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PPAI_IVR.Clases.InformacionCliente", b =>
                {
                    b.HasOne("PPAI_IVR.Clases.Cliente", null)
                        .WithMany("InformacionCliente")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PPAI_IVR.Clases.Validacion", "Validacion")
                        .WithMany()
                        .HasForeignKey("ValidacionId");

                    b.Navigation("Validacion");
                });

            modelBuilder.Entity("PPAI_IVR.Clases.OpcionLlamada", b =>
                {
                    b.HasOne("PPAI_IVR.Clases.Llamada", null)
                        .WithOne("OpcionLlamada")
                        .HasForeignKey("PPAI_IVR.Clases.OpcionLlamada", "LlamadaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PPAI_IVR.Clases.SubOpcionLlamada", b =>
                {
                    b.HasOne("PPAI_IVR.Clases.OpcionLlamada", null)
                        .WithMany("subOpcionLlamadas")
                        .HasForeignKey("opcionLlamadaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PPAI_IVR.Clases.Validacion", b =>
                {
                    b.HasOne("PPAI_IVR.Clases.OpcionLlamada", null)
                        .WithMany("validacionesRequeridas")
                        .HasForeignKey("opcionLlamadaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PPAI_IVR.Clases.CambioEstado", b =>
                {
                    b.Navigation("Estado");
                });

            modelBuilder.Entity("PPAI_IVR.Clases.Cliente", b =>
                {
                    b.Navigation("InformacionCliente");
                });

            modelBuilder.Entity("PPAI_IVR.Clases.Llamada", b =>
                {
                    b.Navigation("CambiosDeEstados");

                    b.Navigation("Cliente");

                    b.Navigation("OpcionLlamada");
                });

            modelBuilder.Entity("PPAI_IVR.Clases.OpcionLlamada", b =>
                {
                    b.Navigation("subOpcionLlamadas");

                    b.Navigation("validacionesRequeridas");
                });
#pragma warning restore 612, 618
        }
    }
}
