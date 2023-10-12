using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClonPersonajeVideoJuego.Models;

namespace ClonPersonajeVideoJuego.ClasesDeHeroes
{
    public class Guerrero : Heroe
    {
        public Guerrero()
        {
            Nombre = "Guerrero Destructor";
            AspectoVisual = "Aspecto Guerrero Destructor";
            Nivel = 1;
            Experiencia = 5;

            Habilidades = new Dictionary<string, int>
            {
                { "Ataque Espada", 10 },
                { "Defensa Escudo", 8 },
                { "Grito de Batalla", 5 }
            };
        }
    }
}
