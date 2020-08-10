using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Entidades
{
    public class Entrenador : Profesor
    {
        public int EntrenadorId { get; set; }
        public List<JugadorEntrenador> JugadorEntrenadores { get; set; } = new List<JugadorEntrenador>();

        public string Hablar()
        {
            return "Hola muchachos este año sere su entrenador Depotivo";
        }
        public string Dirigir()
        {
            return "Me gusta dirigir cerca de los jugadores";
        }
        public string Gritar()
        {
            return "y gritar si no me escuchan";
        }
        public string Ganar()
        {
            return "Me gusta realizar una comida cuando ganamos";
        }

    }
}
