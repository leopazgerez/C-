using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Patrones_de_diseño_builder_
{
    public interface ImedioDePago
    {
        string eleccionMedioDePago(string medioPago);
        string getMedioPago();
    }

}
