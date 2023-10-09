using ClonPersonajeVideoJuego.Models;
using ClonPersonajeVideoJuego.Services;
using Newtonsoft.Json;

HeroeFactory factory = new HeroeFactory();

// Clonar un guerrero y personalizarlo
Heroe miGuerrero = factory.ClonarHeroe("guerrero", "Mi Guerrero", "AspectoGuerrero");
Console.WriteLine($"Copia Guerrero:\n {JsonConvert.SerializeObject(miGuerrero)}\n");

// Clonar un mago y personalizarlo
Heroe miMago = factory.ClonarHeroe("mago", "Mi Mago", "AspectoMago");
Console.WriteLine($"Copia Mago:\n {JsonConvert.SerializeObject(miMago)}\n");

// Clonar un arquero y personalizarlo
Heroe miArquero = factory.ClonarHeroe("arquero", "Mi Arquero", "AspectoArquero");
Console.WriteLine($"Copia Arquero:\n {JsonConvert.SerializeObject(miArquero)}\n");

Console.ReadLine();