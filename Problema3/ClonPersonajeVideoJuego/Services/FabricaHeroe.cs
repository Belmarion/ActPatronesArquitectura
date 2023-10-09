using ClonPersonajeVideoJuego.ClasesDeHeroes;
using ClonPersonajeVideoJuego.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClonPersonajeVideoJuego.Services
{
    public class HeroeFactory
    {
        private Dictionary<string, Heroe> heroes = new Dictionary<string, Heroe>();

        public HeroeFactory()
        {
            heroes.Add("guerrero", new Guerrero());
            heroes.Add("mago", new Mago());
            heroes.Add("arquero", new Arquero());
        }

        public Heroe ClonarHeroe(string tipo, string nombre, string aspectoVisual)
        {
            if (heroes.ContainsKey(tipo))
            {
                Heroe heroe = heroes[tipo].Clone();
                heroe.Nombre = nombre;
                heroe.AspectoVisual = aspectoVisual;
                return heroe;
            }
            else
            {
                throw new ArgumentException("Tipo de héroe no válido.");
            }
        }
    }
}
