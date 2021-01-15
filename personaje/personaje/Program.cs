using System;
using Cliente;
using Informacion;
using Interfaces;

using Ninject;
using System.Reflection;
using Imformacion;

namespace personaje
{
    class Program
    {
        static void Main(string[] args)

        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            var persistencia = kernel.Get<IPersistencia>();

            Console.WriteLine("Hello World!");
           
            LeagueOfLegends leagueOfLegends = new LeagueOfLegends(persistencia);
            Personaje personaje = new Personaje("Akali");
            Pueblo pueblo = new Pueblo("Jonia");
            Habilidades habilidades = new Habilidades("[Q]kunais", "[W]humo", "[E]kunai y Patada");

            leagueOfLegends.InformacionPersonaje(personaje, pueblo, habilidades);

        }

    }
}


