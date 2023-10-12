using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorInformes
{
    public abstract class Informe : PasosInforme
    {
        IFormato formato;

        protected abstract override void consultarBD();

        protected abstract override void aplicarCalculos();


        public void seleccionarFormato(IFormato formato)
        {
            this.formato = formato;
        }

        public string formatearResultado()
        {
            return formato.formatear();
        }
    }
}
