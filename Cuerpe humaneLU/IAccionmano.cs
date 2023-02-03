using System;
using System.Collections.Generic;
using System.Text;

namespace Cuerpe_humaneLU
{
    interface IAccionManos
    {
        void agarrar(Objetos objeto, double peso);
        void soltar();
    }
}
