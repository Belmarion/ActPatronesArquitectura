using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClonPersonajeVideoJuego.Models;

namespace ClonPersonajeVideoJuego.ClasesDeHeroes
{
    public class Arquero : Heroe
    {
        public Arquero()
        {
            Nombre = "Arquero Leviatan";
            AspectoVisual = "Aspecto Arquero Leviatan";
            Nivel = 1;
            Experiencia = 10;

            Habilidades = new Dictionary<string, int>
            {
                { "Disparo Preciso", 11 },
                { "Camuflaje", 7 },
                { "Flecha de Fuego", 6 }
            };
        }
    }
}
