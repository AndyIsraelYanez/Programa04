using Proyecto.Entidades;
using System.Collections.Generic;

namespace Proyecto.Negocio
{
    public class Jugador : Persona
    {
        
        public int JugadorId { get; set; }
        public int EquipoId { get; set; }
        public Equipo Equipo { get; set; }
        public List<Uniforme> Uniformes { get; set; } = new List<Uniforme>();
        public List<JugadorTipoPosicion> JugadorTipoPosiciones { get; set; } = new List<JugadorTipoPosicion>();
        public List<JugadorEntrenador> JugadorEntrenadores { get; set; } = new List<JugadorEntrenador>();

        public void Jugar()
        {
            base.Correr();
        }
    }
}
