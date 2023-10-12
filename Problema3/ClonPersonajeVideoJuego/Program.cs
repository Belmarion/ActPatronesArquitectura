using ClonPersonajeVideoJuego.ClasesDeHeroes;
using ClonPersonajeVideoJuego.Models;
using ClonPersonajeVideoJuego.Services;
using Newtonsoft.Json;

HeroeFactory factory = new HeroeFactory();

Arquero arquero = new Arquero();
Guerrero guerrero = new Guerrero();
Mago mago = new Mago();

Console.WriteLine($"Arquero Original:\n {JsonConvert.SerializeObject(arquero)}\n");
Console.WriteLine($"guerrero Original:\n {JsonConvert.SerializeObject(guerrero)}\n");
Console.WriteLine($"Mago Original:\n {JsonConvert.SerializeObject(mago)}\n");


// Clonar un arquero y personalizarlo
Heroe arqueroClon = arquero.Clone();
arqueroClon.CambiarNombre("Arquero del Inframundo", "Arquero Infernal");
Console.WriteLine($"Copia Arquero:\n {JsonConvert.SerializeObject(arqueroClon)}\n");

// Clonar un Guerrero y personalizarlo
Heroe guerreroClon = guerrero.Clone();
guerreroClon.CambiarNombre("Guerrero de Luz", "Guerrero Solar");
Console.WriteLine($"Copia Guerrero:\n {JsonConvert.SerializeObject(guerreroClon)}\n");

// Clonar un arquero y personalizarlo
Heroe MagoClon = mago.Clone();
MagoClon.CambiarNombre("Mago Lunar", "Mago Lunar");
Console.WriteLine($"Copia Mago:\n {JsonConvert.SerializeObject(MagoClon)}\n");

Console.ReadLine();