using System.Collections.Generic;

namespace Institucion.Negocio
{
    public class TipoPosicion
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int IdTipoPosicion { get; set; }
        public string Nombre { get; set; }

        //modelar una lista de jugadores con una propiedad

        public List<TipoPosicionJugador> TipoPosicionJugadores { get; set; } = new List<TipoPosicionJugador>();
    }
}
