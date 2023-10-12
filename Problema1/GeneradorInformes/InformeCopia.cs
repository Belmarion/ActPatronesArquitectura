using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorInformes
{
    public abstract class InformeCopia
    {
        IFormato formato;

        public void seleccionarFormato(IFormato formato)
        {
            this.formato = formato;
        }

        public string formatearResultado()
        {
            return formato.formatear();
        }


        public void generarInforme()
        {

            this.obtenerDatosConsulta();
            this.consultarBD();
            this.aplicarCalculos();
            this.mostrarResultados();
        }


        protected void obtenerDatosConsulta()
        {
            Console.WriteLine("Generando consulta");
        }

        protected abstract void consultarBD();

        protected abstract void aplicarCalculos();


        protected void mostrarResultados()
        {
            Console.WriteLine("Mostrando resultado informe");
        }

    }

}

