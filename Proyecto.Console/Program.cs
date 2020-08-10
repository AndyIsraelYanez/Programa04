using Proyecto.Negocio;
using Proyecto.Entidades;
using Microsoft.EntityFrameworkCore.Design;
using System;
namespace Proyecto.Consola
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenidos Institución Deportiva!");
            Console.WriteLine("--------------");
            Console.WriteLine("** Presione Enter para continuar **");
            Console.ReadKey();
            Console.WriteLine("¿Ingrese su nombre para acceder a la información?");
           
            string nombreUsuario = Console.ReadLine();
            Console.WriteLine("--------------");


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

            Uniforme uniforme = new Uniforme
            {
                Marca = "Puma",
                Modelo = "xl"
            };

            Uniforme uniforme1 = new Uniforme
            {
                Marca = "Puma",
                Modelo = "wse"
            };


            Equipo equipo = new Equipo
            {
                Nombre = "LDU"
            };

            Entrenador entrenador = new Entrenador
            {
                Nombre = "Pablo",
                Apellido = "Repetto",
                Cargo = "Director Técnico",
                AñosdeProfesion = "8 años ",
                Nacimiento = new DateTime(1990, 6, 12)

            };

            Entrenador entrenador1 = new Entrenador
            {
                Nombre = "Gorky",
                Apellido = "Estrella",
                Cargo = "Preparador de arqueros",
                AñosdeProfesion = "6 años ",
                Nacimiento = new DateTime(1989, 10, 11)

            };
            var equipox = equipo.Nombre;

            Vocal vocal0 = new Vocal();
            vocal0.Inscribir(jugador, tipoPosicion);

            Vocal vocal1 = new Vocal();
            vocal1.Inscribir(jugador1, tipoPosicion1);

            Vocal vocal2 = new Vocal();
            vocal2.Agregar(jugador, equipo);

            Vocal vocal3 = new Vocal();
            vocal3.Indicar(jugador, uniforme);

            Vocal vocal4 = new Vocal();
            vocal4.Indicar(jugador, uniforme);

            Vocal vocal5 = new Vocal();
            vocal5.Designar(jugador, entrenador);

            Vocal vocal6 = new Vocal();
            vocal6.Designar(jugador, entrenador1);

            Console.WriteLine($"Existen {Vocal.Inscritos} jugadores Inscritos  para que puedan Jugar");

            Console.WriteLine($"La Vocal designo  {Vocal.Agregados} equipo llamado {equipox} ha  estos jugadores  {jugador.Nombre}, {jugador1.Nombre} ");

            Console.WriteLine($"Estos  {Vocal.Dar} uniformes  son para un solo jugador {jugador.Nombre}");

            Console.WriteLine($"Existen {Vocal.Designados} Entrenadores para los {Vocal.Inscritos} Jugadores que ya fueron registrados");

            Console.WriteLine("--------------------------------");

            Console.WriteLine($"Muchas gracias  {nombreUsuario} por visitarnos");
            
        }
    }
}
