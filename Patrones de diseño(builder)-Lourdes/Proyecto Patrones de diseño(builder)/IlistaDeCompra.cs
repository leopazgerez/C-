﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Patrones_de_diseño_builder_
{
    public interface IlistaDeCompra
    {
        void PosibleListaDeCompra(Producto producto, int cantidad);
        void getLista(); 
    }
}
