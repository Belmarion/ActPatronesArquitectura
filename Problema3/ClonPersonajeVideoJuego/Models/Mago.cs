using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClonPersonajeVideoJuego.Models
{
    public class Mago : Heroe
    {
        public Mago()
        {
            Nombre = "Mago Oscuro";
            AspectoVisual = "Aspecto Mago Oscuro";
            Nivel = 1;
            Experiencia = 0;

            Habilidades = new Dictionary<string, int>
            {
                { "Bola de Fuego", 12 },
                { "Escudo Arcano", 6 },
                { "Teletransportación", 4 }
            };
        }
    }
}
