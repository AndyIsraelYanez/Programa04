using Institucion.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace Instituto.AccedoDatos
{
    public class ApplicationDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {//conexion a base de datos 
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appconfig.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }
        //modelo tabla
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoPosicionJugador>()
                .ToTable("JugadorPorPosicion")
                .HasKey(jt => new { jt.TipoPosicionId, jt.JugadorId });

            modelBuilder.Entity<Jugador>()
                .HasKey(j => new { j.JugadorId });
        }
        public DbSet<Jugador> Jugadores { get; set; }
        public DbSet<TipoPosicion> TipoPosiciones { get; set; }
        public DbSet<TipoPosicionJugador> TipoPosicionJugadores { get; set; }
    }
}
