using Institucion.Negocio;
using Instituto.Entidad;
using Microsoft.EntityFrameworkCore.Design;
using System;
namespace Institucion.Consola
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenidos a inscribirse Jugadores!");
            Jugador jugador = new Jugador
            {
                Nombre = "Israel",
                Apellido = "Yanez",
                Nacimiento = new DateTime(2000, 4, 7)
            };

            Jugador jugador1 = new Jugador
            {
                Nombre = "Marco",
                Apellido = "Diaz",
                Nacimiento = new DateTime(1999, 4, 7)
            };

            TipoPosicion tipoPosicion = new TipoPosicion
            {
                Nombre = "MedioCentro"
            };
            TipoPosicion tipoPosicion1 = new TipoPosicion

            {
                Nombre = "Delantero"
            };

            Equipo equipo = new Equipo
            {
                Nombre = "LDU"
            };

            var equipox = equipo.Nombre;

            Secretaria secretaria0 = new Secretaria();
            secretaria0.Inscribir(jugador, tipoPosicion);

            Secretaria secretaria1 = new Secretaria();
            secretaria1.Inscribir(jugador1, tipoPosicion1);

            Secretaria secretaria2 = new Secretaria();
            secretaria2.Agregar(jugador, equipo);


            Console.WriteLine($"Existen {Secretaria.Inscritos} jugadores Inscritos  para que puedan Jugar");

            Console.WriteLine($"secretaria designo  {Secretaria.Agregados} equipo llamado {equipox} ha  estos jugadores  {jugador.Nombre}, {jugador1.Nombre} ");
            //{ equipo.Jugadores[0].Nombre}


        }
    }
}
