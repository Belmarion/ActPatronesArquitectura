using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClonPersonajeVideoJuego.Interfaces
{
    public interface IClonacion<T>
    {
        T Clone();
    }
}
