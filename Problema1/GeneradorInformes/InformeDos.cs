using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorInformes
{
    public class InformeDos : Informe
    {
        protected override void consultarBD()
        {
            Console.WriteLine("Consultando en BD ...");
        }

        protected override void aplicarCalculos()
        {
            Console.WriteLine("Generando informe ...");
        }

       
    }
}
