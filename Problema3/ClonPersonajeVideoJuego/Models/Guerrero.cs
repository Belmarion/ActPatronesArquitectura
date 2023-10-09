using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClonPersonajeVideoJuego.Models
{
    public class Guerrero : Heroe
    {
        public Guerrero()
        {
            Nombre = "Guerrero Destructor";
            AspectoVisual = "Aspecto Guerrero Destructor";
            Nivel = 1;
            Experiencia = 0;

            Habilidades = new Dictionary<string, int>
            {
                { "Ataque Espada", 10 },
                { "Defensa Escudo", 8 },
                { "Grito de Batalla", 5 }
            };
        }
    }
}
