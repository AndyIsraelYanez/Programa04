using System;

namespace Proyecto.Entidades
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Nacimiento { get; set; }
        //solo mis desendientes pueden usarlo proteced
        protected void Correr()
        {
            //to do
        }
    }
}