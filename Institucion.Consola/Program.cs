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
            TipoPosicion tipoPosicion = new TipoPosicion
            {
                Nombre = "MedioCentro"
            };
            TipoPosicion tipoPosicion1 = new TipoPosicion

            {
                Nombre = "Delantero"
            };

           
            Secretaria secretaria0 = new Secretaria();
            secretaria0.Inscribir(jugador, tipoPosicion);

            Secretaria secretaria1 = new Secretaria();            
            secretaria1.Inscribir(jugador,tipoPosicion1);

           


            Console.WriteLine($"Existen {Secretaria.Inscritos} deportistas Inscritos  para que puedan trabajar");
           
        }
    }
}
