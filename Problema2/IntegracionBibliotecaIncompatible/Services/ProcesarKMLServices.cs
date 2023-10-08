using IntegracionBibliotecaIncompatible.Dll;
using IntegracionBibliotecaIncompatible.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoJSON.Net;
using GeoJSON.Net.Feature;
using GeoJSON.Net.Geometry;
using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;
using NetTopologySuite.IO;

namespace IntegracionBibliotecaIncompatible.Services
{
    public class ProcesarKMLServices : IGeografia
    {
        private KmlDll kmlDll = new();
        public void CargarDatos(string data)
        {
            string infoKml = ConvertGeoJSONToKML(data);
            kmlDll.CargarInformacionKML(infoKml);
        }

        public void MostrarDatos()
        {
            kmlDll.ProcesamientoKMLInformacion();
        }

        private string ConvertGeoJSONToKML(string geoJSONData)
        {
            string xmlKML = string.Empty;
            try
            {
                var geoJsonReader = new GeoJsonReader();
                var featureCollection = geoJsonReader.Read<FeatureCollection>(geoJSONData);

                var document = new Document();

                foreach (var feature in featureCollection.Features)
                {
                    if (feature.Geometry is GeoJSON.Net.Geometry.Point point)
                    {
                        var placemark = new Placemark();
                        placemark.Geometry = new SharpKml.Dom.Point
                        {
                            Coordinate = new Vector(point.Coordinates.Longitude, point.Coordinates.Latitude)
                        };

                        document.AddFeature(placemark);
                    }
                }

                var kmlSerializer = new Serializer();
                kmlSerializer.Serialize(document);

                xmlKML = kmlSerializer.Xml.ToString();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Se presento un error al convertir el GeoJson a KML");
            }
            return xmlKML;
        }
    }
}
