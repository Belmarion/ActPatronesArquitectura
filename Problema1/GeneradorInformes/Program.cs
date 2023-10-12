// See https://aka.ms/new-console-template for more information

using GeneradorInformes;

String tipoInforme = "";
Informe informe;
String tipoFormato = "";

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine(" .:: Generador de informes ::.");
Console.WriteLine(" ");
Console.WriteLine("Ingrese el número de informe a generar: 1-Informe Uno  2-Informe Dos  3-Informe Tres");
tipoInforme = Console.ReadLine();

if (tipoInforme == "1")
{
    informe = new InformeUno();
   
}
else if (tipoInforme == "2")
{
    informe = new InformeDos();
}
else {
    informe = new InformeTres();

}
informe.generar();

Console.ForegroundColor= ConsoleColor.DarkGreen;
Console.WriteLine(" ");
Console.WriteLine("Seleccione tipo de formato para imprimir: a-CSV  b-PDF  c-HTML");
tipoFormato = Console.ReadLine();

if (tipoFormato == "a")
{
    informe.seleccionarFormato(new FormatoCSV());
}
else if (tipoFormato == "b")
{
    informe.seleccionarFormato(new FormatoPDF());
}
else
{
    informe.seleccionarFormato(new FormatoHTML());

}
Console.WriteLine(informe.formatearResultado());
Console.ForegroundColor = ConsoleColor.White;