using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Patrones_de_diseño_builder_
{
    public class MedioDePago : ImedioDePago
    {
        string medioDePago;

        public string eleccionMedioDePago(string medioPago)
        {
            return medioDePago = medioPago;
        }

        public string getMedioPago()
        {
            return medioDePago; 
        }
    }
}
