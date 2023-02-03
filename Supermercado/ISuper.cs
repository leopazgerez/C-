using System;
using System.Collections.Generic;
using System.Text;

namespace Supermercado
{
    public interface ISuper
    {
        public void CompraVenta(Cliente cliente);
        public void SelecciondeProducto(Producto producto, int cantidad);
    }
}
