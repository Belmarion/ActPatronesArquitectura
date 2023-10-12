using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorInformes
{
    public class InformeTres : Informe
    {
        protected override void consultarBD()
        {
            Console.WriteLine("Consultado en BD ...");
        }

        protected override void aplicarCalculos()
        {
            Console.WriteLine("Aplicando calculos ...");
        }

    }
}
