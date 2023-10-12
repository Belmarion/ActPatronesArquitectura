using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorInformes
{
    internal class FormatoCSV : IFormato
    {
        public string formatear()
        {
            return "formato CSV aplicado";
        }
    }
}
