using Instituto.Entidad;
using System.Collections.Generic;


namespace Institucion.Negocio
{
    public class Jugador: Persona
    {
        public int JugadorId { get; set; }
        public int EquipoId { get; set; }

        public List<TipoPosicionJugador> TipoPosicionJugadores { get; set; } = new List<TipoPosicionJugador>();
        public void Jugar()
        {
            base.Correr();
        }
    }
}
