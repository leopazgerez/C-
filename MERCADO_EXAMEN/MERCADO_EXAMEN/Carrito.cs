using System;
using System.Collections.Generic;
using System.Text;

namespace MERCADO_EXAMEN
{
    class Carrito
    {
        public List<Producto> Lista_Productos;
        public double PrecioTotal;
        
        public Carrito()
        {
            this.Lista_Productos = new List<Producto>();
            this.PrecioTotal = 0;
        }
        public void Agregar(Producto _Producto)
        {
            this.Lista_Productos.Add(_Producto);
            if (_Producto.Descuento == 0)
            {
                this.PrecioTotal += (_Producto.Stock * _Producto.Precio);
            }
            else
            {
                this.PrecioTotal += (_Producto.Stock * _Producto.Precio)- ((_Producto.Stock * _Producto.Precio)/100)*_Producto.Descuento;
            }
        }
    }
}
