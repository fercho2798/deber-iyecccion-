using Imformacion;
using Informacion;
namespace Interfaces
{
    public interface IPersistencia
    {
        public bool Grabar(Personaje personaje);

        public bool Grabar(Pueblo pueblo);

        public bool Grabar(PersonajePorPueblo personajePorPueblo);

        public bool Grabar(Habilidades habilidades);
    }
}


