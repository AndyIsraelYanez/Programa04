﻿// <auto-generated />
using System;
using Instituto.AccedoDatos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Instituto.AccedoDatos.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200806055844_Inicio")]
    partial class Inicio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Institucion.Negocio.Jugador", b =>
                {
                    b.Property<int>("JugadorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Nacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JugadorId");

                    b.ToTable("jugadores");
                });

            modelBuilder.Entity("Institucion.Negocio.TipoPosicion", b =>
                {
                    b.Property<int>("IdTipoPosicion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTipoPosicion");

                    b.ToTable("TipoPosiciones");
                });

            modelBuilder.Entity("Institucion.Negocio.TipoPosicionJugador", b =>
                {
                    b.Property<int>("TipoPosicionId")
                        .HasColumnType("int");

                    b.Property<int>("JugadorId")
                        .HasColumnType("int");

                    b.HasKey("TipoPosicionId", "JugadorId");

                    b.HasIndex("JugadorId");

                    b.ToTable("JugadorPorPosicion");
                });

            modelBuilder.Entity("Institucion.Negocio.TipoPosicionJugador", b =>
                {
                    b.HasOne("Institucion.Negocio.Jugador", "Jugador")
                        .WithMany("TipoPosicionJugadores")
                        .HasForeignKey("JugadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Institucion.Negocio.TipoPosicion", "TipoPosicion")
                        .WithMany("TipoPosicionJugadores")
                        .HasForeignKey("TipoPosicionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
