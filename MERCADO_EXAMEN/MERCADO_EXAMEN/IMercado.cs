using System;
using System.Collections.Generic;
using System.Text;

namespace MERCADO_EXAMEN
{
    interface IMercado
    {
        public List<Producto> MisProductos();
        public List<Cliente> MisClientesPreferenciales();
    }
}
