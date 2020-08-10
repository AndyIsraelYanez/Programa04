using Proyecto.Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Proyecto.Entidades
{
    public class Uniforme
    {
        public int UniformeId { get; set; }
        public int JugadorId { get; set; }
        public Jugador Jugador { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }

        public string Detallar()
        {
            return "Es una de las mejores camisetas del Campeonato";
        }
    }
}
