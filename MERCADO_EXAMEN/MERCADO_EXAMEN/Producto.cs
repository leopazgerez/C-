using System;
using System.Collections.Generic;
using System.Text;

namespace MERCADO_EXAMEN
{
    class Producto
    {
        public String Nombre;
        private int Codigo;
        public double Precio;
        public int Stock;
        public float Descuento;
        
        public Producto(String Nombre,int Codigo, double Precio,int Stock,int Descuento)
        {
            this.Nombre = Nombre;
            this.Codigo = Codigo;
            this.Precio = Precio;
            this.Stock = Stock;
            this.Descuento = Descuento;
        }
        public override string ToString()
        {
            String Mostrando = "";
            if (this.Descuento != 0)
            {
                Mostrando += "Nombre :" + this.Nombre + "\nPrecio:" + this.Precio + "\nCantidad:" + this.Stock + "\nDescuento:" + this.Descuento + "%";
            }
            else
            {
                Mostrando += "Nombre :" + this.Nombre + "\nPrecio:" + this.Precio + "\nCantidad:" + this.Stock;
            }

            return Mostrando;
        }
    }
}
