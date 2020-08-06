using Institucion.Negocio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Instituto.Entidad
{
    class Equipo
    {
        public int EquipoI { get; set; }
        public string Nombre { get; set; }
        public List<Jugador> Jugadores { get; set; } = new List<Jugador>();


    }
}
