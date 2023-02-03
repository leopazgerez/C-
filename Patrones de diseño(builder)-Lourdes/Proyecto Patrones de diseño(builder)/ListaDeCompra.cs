using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Patrones_de_diseño_builder_
{
    public class ListaDeCompra: IlistaDeCompra
    {
        int cantidad;
        List<Producto> listaDeCompra = new List<Producto>();
        public void PosibleListaDeCompra(Producto producto, int elegirCantidad)
        {
            cantidad = elegirCantidad;

            this.listaDeCompra.Add(producto);

        }

        public void getLista()
        {
            foreach (Producto producto in listaDeCompra)
            {
                Console.WriteLine(producto.getInfoProductos() + cantidad);

            }
        }
    }
}
