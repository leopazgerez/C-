using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Patrones_de_diseño_builder_
{
    class Director
    {
        public void crearCarrito(Icarrito pConstructor)
        {
            pConstructor.Cliente();
           // pConstructor.listaCompra(lista[]);
            pConstructor.medioDePago(); 

        }
    }
}
