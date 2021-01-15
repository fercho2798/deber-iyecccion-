using System;

namespace Informacion
{
    public class Pueblo
    {
        public Pueblo(string nombre)
        {
            Nombre = nombre;

            Id = new Random().Next();
        }
        public string Nombre { get; set; }
        public int Id { get; set; }
    }
}


