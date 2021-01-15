using System;

namespace Informacion
{
    public class PersonajePorPueblo
    {
        public int PersonajeId { get; set; }
        public int PuebloId { get; set; }
        public int HabilidadesId { get; set; }
        public int Id { get; set; } = new Random().Next();
    }
}


