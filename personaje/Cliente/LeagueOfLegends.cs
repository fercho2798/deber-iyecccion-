using Imformacion;
using Informacion;
using Interfaces;
namespace Cliente
{
    public class LeagueOfLegends 
    {
        static IPersistencia persistencia;
        public LeagueOfLegends(IPersistencia persistencia)
        {
            LeagueOfLegends.persistencia = persistencia;
        }

        public string InformacionPersonaje(Personaje personaje, Pueblo pueblo, Habilidades habilidades)
        {
            persistencia.Grabar(personaje);
            persistencia.Grabar(pueblo);
            persistencia.Grabar(habilidades);
            persistencia.Grabar(new PersonajePorPueblo
            { 
                PersonajeId = personaje.Id, PuebloId = pueblo.Id, HabilidadesId = habilidades.Id
            });
            return string.Format("El campeon {0} {1} es del pueblo {2} y sus habilidades son {3} "
                , personaje.Nombre
                , pueblo.Nombre
                , habilidades.Nombre
                , habilidades.Nombre1
                , habilidades.Nombre2);


        }
    }
}


