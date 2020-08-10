
using Proyecto.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using Proyecto.Entidades;

namespace Proyecto.AccesoDatos
{
    public class ApplicationDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {//conexion a base de datos 
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appconfig.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JugadorTipoPosicion>()
                .ToTable("JugadorPorPosicion")
                .HasKey(jt => new { jt.TipoPosicionId, jt.JugadorId });

            modelBuilder.Entity<JugadorEntrenador>()
               .ToTable("JugadorPorEntrenador")
               .HasKey(je => new { je.EntrenadorId, je.JugadorId });

            modelBuilder.Entity<Jugador>()
             .HasKey(j => new { j.JugadorId });

            modelBuilder.Entity<Uniforme>()
            .HasKey(u => new { u.UniformeId });

            modelBuilder.Entity<Equipo>()
           .HasKey(e => new { e.EquipoId });        
        }
        public DbSet<Jugador> Jugadores { get; set; }
        public DbSet<TipoPosicion> TipoPosiciones { get; set; }
        public DbSet<JugadorTipoPosicion> JugadorTipoPosiciones { get; set; }
        public DbSet<Uniforme> Uniformes { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<JugadorEntrenador> JugadorEntrenadores { get; set; }
        public DbSet<Entrenador> Entrenadores { get; set; }
    }
}

