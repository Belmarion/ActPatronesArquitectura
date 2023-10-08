using IntegracionBibliotecaIncompatible.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegracionBibliotecaIncompatible.Services
{
    public class ProcesarGeoJsonServices : IGeografia
    {
        private string? _geoJson;
        public void CargarDatos(string data)
        {
            _geoJson = data;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Mostrar GeoJSON: {_geoJson} \n");
        }
    }
}
