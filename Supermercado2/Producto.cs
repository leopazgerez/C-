using System;
using System.Collections.Generic;
using System.Text;

namespace Supermercado2
{
    class Producto
    {
        public string Nombre;
        public double id_producto;
        public double Precio;
        public double Stock;
        public Producto(string nombre, double id, double precio, double cantidaddisponible) 
        {
            Nombre = nombre;
            id_producto = id;
            Precio = precio;
            Stock = cantidaddisponible;
        }
    }
}
