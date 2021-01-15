using System.Collections.Generic;
using System.IO;
using Imformacion;
using Informacion;
using Interfaces;


namespace Implementaciones
{
    public class Persistencia : IPersistencia
    {
        public bool Grabar(Pueblo pueblo)
        {
            File.AppendAllLines("Personaje.txt", new List<string> { pueblo.ToString() });
            return true;
        }
        public bool Grabar(Personaje personaje)
        {
            File.AppendAllLines("Pueblo.txt", new List<string> { personaje.ToString() });
            return true;
        }
        public bool Grabar(PersonajePorPueblo personajePorPueblo)
        {
            File.AppendAllLines("PersonajePorPueblo.txt", new List<string> { personajePorPueblo.ToString() });
            return true;
        }
        public bool Grabar(Habilidades habilidades)
        {
            File.AppendAllLines("Habilidades.txt", new List<string> { habilidades.ToString() });
            return true;
        }
    }
}


