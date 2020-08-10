
namespace Proyecto.Negocio
{
     public class JugadorTipoPosicion 
    {
        public int JugadorId { get; set; }
        public Jugador Jugador { get; set; }
        public int TipoPosicionId { get; set; }
        public TipoPosicion TipoPosicion { get; set; }
            
    }
}
