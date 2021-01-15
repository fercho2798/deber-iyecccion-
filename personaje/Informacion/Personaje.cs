using System;

namespace Imformacion
{
    public class Personaje
    {
        public Personaje(string nombre)
        {
            Nombre = nombre;

            Id = new Random().Next();
        }
        public string Nombre { get; set; }
        public int Id { get; set; }
    }
}


