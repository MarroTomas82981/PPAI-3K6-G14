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
    [Migration("20230525234006_Llamadas")]
    partial class Llamadas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PPAI_IVR.Clases.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NombreCompleto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("nroCelular")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("PPAI_IVR.Clases.Llamada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

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

                    b.HasIndex("ClienteId");

                    b.ToTable("Llamadas");
                });

            modelBuilder.Entity("PPAI_IVR.Clases.Llamada", b =>
                {
                    b.HasOne("PPAI_IVR.Clases.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.Navigation("Cliente");
                });
#pragma warning restore 612, 618
        }
    }
}
