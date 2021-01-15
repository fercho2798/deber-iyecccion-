using Implementaciones;
using Interfaces;
using MasDatos;
using Ninject.Modules;

namespace personaje
{
    public class ModuloPersistencia : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IPersistencia>().To<Persistencia>();
        }
    }
}


