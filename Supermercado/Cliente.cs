using System;
using System.Collections.Generic;
using System.Text;

namespace Supermercado
{
    public class Cliente : ISuper
    {
        private string Nombre;
        private double DNI;
        public double Descuento;
        public ISuper Super;
        public List<Producto> CarritodeCompras = new List<Producto>();



        public Cliente(ISuper super, string nombre, double descuento)
        {
            Nombre = nombre;
            Descuento = descuento;
            Super = super;
        }

        public void CompraVenta(Cliente cliente) 
        {
            Super.CompraVenta(cliente);
        }

        public void SelecciondeProducto(Producto ProductoASeleccionar, int cantidad) 
        {
            CarritodeCompras.Add(ProductoASeleccionar);
        }
    }
}
