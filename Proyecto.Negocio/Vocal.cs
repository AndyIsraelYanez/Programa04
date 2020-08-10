using Proyecto.Entidades;

namespace Proyecto.Negocio
{
    public class Vocal
    {
        public static int Inscritos { get; set; }
        public static int Agregados { get; set; }
        public static int Dar { get; set; }
        public static int Designados { get; set; }
        public void Inscribir(Jugador jugador, TipoPosicion tipoPosicion)
        {
            jugador.JugadorTipoPosiciones.Add(new JugadorTipoPosicion
            {
                TipoPosicion = tipoPosicion,
                Jugador = jugador
            });
            Inscritos++;
        }
        public void Agregar(Jugador jugador, Equipo equipo)
        {
            equipo.Jugadores.Add(new Jugador
            {
                Nombre = jugador.Nombre,
                Apellido = jugador.Apellido

            });
            Agregados++;
        }
        public void Indicar(Jugador jugador, Uniforme uniforme)
            {
                jugador.Uniformes.Add(new Uniforme
                {
                    Modelo = uniforme.Modelo,
                    Marca = uniforme.Marca

                });
                Dar++;

            }
        public void Designar(Jugador jugador, Entrenador entrenador)
        {
            jugador.JugadorEntrenadores.Add(new JugadorEntrenador
            {
                Entrenador = entrenador,
                Jugador = jugador
            });
            Designados++;
        }

    }
}