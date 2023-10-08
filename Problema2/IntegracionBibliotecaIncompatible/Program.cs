
using IntegracionBibliotecaIncompatible.Interfaces;
using IntegracionBibliotecaIncompatible.Services;

string data = "{\"type\":\"FeatureCollection\",\"features\":[{\"type\":\"Feature\",\"geometry\":{\"type\":\"Point\",\"coordinates\":[1,2]},\"properties\":{}}]}";

IGeografia geografiaGeoJson = new ProcesarGeoJsonServices();
IGeografia geografiaKML = new ProcesarKMLServices();

// simulación de implementación existente de GeoJson
geografiaGeoJson.CargarDatos(data);
geografiaGeoJson.MostrarDatos();

// Implemtnación de conversión GeoJson a KML
geografiaKML.CargarDatos(data);
geografiaKML.MostrarDatos();

Console.ReadLine();
