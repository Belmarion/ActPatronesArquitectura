using ClonPersonajeVideoJuego.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClonPersonajeVideoJuego.Models
{
    public class Heroe : IClonacion<Heroe>
    {
        public string Nombre { get; set; } = null!;
        public string? AspectoVisual { get; set; }
        public int Nivel { get; set; }
        public int Experiencia { get; set; }
        public Dictionary<string, int> Habilidades { get; set; } = null!;

        public Heroe Clone()
        {
            return (Heroe)this.MemberwiseClone();
        }
        public void CambiarNombre(string nombre, string aspectoVisual)
        {
            this.Nombre = nombre;
            this.AspectoVisual = aspectoVisual;
        }

    }
}
