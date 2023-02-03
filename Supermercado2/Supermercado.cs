using System;
using System.Collections.Generic;
using System.Text;

namespace Supermercado2
{
    class Supermercado : ISuper
    {
        public List<Producto> Productosdisponibles;
        public Cliente cliente;
        public int CantidadDeCompras;
        public Supermercado() 
        {
            Productosdisponibles = new List<Producto>();
        }
        public void Productosengondola() 
        {
            foreach (Producto producto in Productosdisponibles)
            {
                Console.WriteLine("Nombre: "+ producto.Nombre +" Cantidad Disponible: "+ producto.Stock);
            }
        }
        public void comprar() 
        { 

        }
    }
}
