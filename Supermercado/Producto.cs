using System;
using System.Collections.Generic;
using System.Text;

namespace Supermercado
{
    public class Producto
    {
        public string Nombre;
        private double Codigo;
        public double Precio;
        public int Cantidad;

        public Producto(string nombre, float precio, int cantidad) 
        {
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }
    }
}
