using Proyecto.Negocio;
using System;
using System.Collections.Generic;
using System.Text;
namespace Proyecto.Entidades
{
    public class Equipo
    {
        
        public string EquipoId { get; set; }
        public string Nombre { get; set; }
        public List<Jugador> Jugadores { get; set; } = new List<Jugador>();

    }
}
