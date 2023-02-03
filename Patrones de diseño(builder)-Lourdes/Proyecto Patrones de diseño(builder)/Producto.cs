using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Patrones_de_diseño_builder_
{
    public class Producto
    {
        private string nombre;
        public int codigo;
        public double precio;



        public Producto(string nombre, int codigo, double precio)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.precio = precio;


        }


        public string getInfoProductos()
        {

            return $"\n Producto: {nombre} \n Codigo: {codigo} \n Precio: ${precio} ";
        }
    }
}
