using System;

namespace Imformacion
{
    public class Habilidades
    {
        public Habilidades(string habilidades, string habilidades2, string habilidades3)
        {
            Nombre = habilidades;
            Nombre1 = habilidades2;
            Nombre2 = habilidades3;
       

            Id = new Random().Next();
        }
        public string Nombre { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public int Id { get; set; }
    }
}


