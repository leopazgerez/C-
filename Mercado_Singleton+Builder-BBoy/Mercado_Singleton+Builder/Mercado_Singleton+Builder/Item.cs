using System;
using System.Collections.Generic;
using System.Text;

namespace Mercado_Singleton_Builder
{
    class Item
    {
        Producto _Producto;
        double Costo;
        int Cantidad;
        
        public Item(Producto _Producto,double _Costo,int _Cantidad)
        {
            this._Producto = _Producto;
            this.Costo = _Costo;
            this.Cantidad = _Cantidad;
        }
        public double getCosto() { return this.Costo; }
    }
}
