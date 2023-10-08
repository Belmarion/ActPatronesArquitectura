using InformesPersonalizados.Interfaces;
using InformesPersonalizados.Services;

IInforme reportesPdf = new ReportePdfServices();
IInforme reportesExcel = new ReporteExcelServices();
IInforme reportesHtml = new ReporteHtmlServices();

reportesPdf.GenerarReporte();
reportesExcel.GenerarReporte();
reportesHtml.GenerarReporte();

Console.ReadLine();