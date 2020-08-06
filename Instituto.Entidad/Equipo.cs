using Institucion.Negocio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Instituto.Entidad
{
     public class Equipo
    {
        public int EquipoId { get; set; }
        public string Nombre { get; set; }
        public List<Jugador> Jugadores { get; set; } = new List<Jugador>();
    }
}
