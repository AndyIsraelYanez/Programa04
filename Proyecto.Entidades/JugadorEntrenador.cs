using Proyecto.Negocio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Entidades
{
    public class JugadorEntrenador
    {
        public int EntrenadorId { get; set; }
        public Entrenador Entrenador { get; set; }
        public int JugadorId { get; set; }
        public Jugador Jugador { get; set; }
    }
}
