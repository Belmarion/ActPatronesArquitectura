using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorInformes
{
    public class InformeUno : Informe
    {
       

        protected override void consultarBD()
        {
            Console.WriteLine("Generando informe ...");
        }

        protected override void aplicarCalculos()
        {
            Console.WriteLine("Aplicando calculos ...");
        }


    }
}
