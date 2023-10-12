using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClonPersonajeVideoJuego.Models;

namespace ClonPersonajeVideoJuego.ClasesDeHeroes
{
    public class Mago : Heroe
    {
        public Mago()
        {
            Nombre = "Mago Oscuro";
            AspectoVisual = "Aspecto Mago Oscuro";
            Nivel = 1;
            Experiencia = 2;

            Habilidades = new Dictionary<string, int>
            {
                { "Bola de Fuego", 12 },
                { "Escudo Arcano", 6 },
                { "Teletransportación", 4 }
            };
        }
    }
}
