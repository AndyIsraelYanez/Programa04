using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Negocio
{
     public class TipoPosicion
    {
        public int TipoPosicionId { get; set; }
        public string Nombre { get; set; }
        public List<JugadorTipoPosicion> JugadorTipoPosiciones { get; set; } = new List<JugadorTipoPosicion>();
    }
    
}
