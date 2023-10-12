using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorInformes
{
    public abstract class PasosInforme
    {
        public void generar()
        {

            this.obtenerDatosConsulta();
            this.consultarBD();
            this.aplicarCalculos();
            this.mostrarResultados();
        }


        protected void obtenerDatosConsulta()
        {
            Console.WriteLine("Obteniendo datos de consulta ...");
        }

        protected abstract void consultarBD();

        protected abstract void aplicarCalculos();


        protected void mostrarResultados()
        {
            Console.WriteLine("Mostrando resultado informe");
        }

    }
}
