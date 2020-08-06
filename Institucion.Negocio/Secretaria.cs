using Instituto.Entidad;
namespace Institucion.Negocio
{
    public class Secretaria
    {
        public static int Inscritos { get; set; }
        public static int Agregados { get; set; }
        public void Inscribir(Jugador jugador, TipoPosicion tipoPosicion)
        {
            jugador.TipoPosicionJugadores.Add(new TipoPosicionJugador
            {
                TipoPosicion = tipoPosicion,
                Jugador = jugador,
            });
            Inscritos++;
        }

    }
}
