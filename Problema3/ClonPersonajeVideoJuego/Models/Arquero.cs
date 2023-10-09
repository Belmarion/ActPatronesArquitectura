using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClonPersonajeVideoJuego.Models
{
    public class Arquero : Heroe
    {
        public Arquero()
        {
            Nombre = "Arquero Leviatan";
            AspectoVisual = "Aspecto Arquero Leviatan";
            Nivel = 1;
            Experiencia = 0;

            Habilidades = new Dictionary<string, int>
            {
                { "Disparo Preciso", 11 },
                { "Camuflaje", 7 },
                { "Flecha de Fuego", 6 }
            };
        }
    }
}
