using System;
using System.Collections.Generic;
using System.Text;

namespace Supermercado
{
    public class Supermercado : ISuper
    {
        public List<Producto> ListaDeProductos = new List<Producto>();
        public Cliente cliente;
        public double totalCompra;
        public double totalPagar;

        public Supermercado()
        {

        }

        public void ProductosDisponibles()
        {
            Console.WriteLine("Lista de productos disponibles");
            foreach (Producto productogondola in ListaDeProductos)
            {
                Console.WriteLine("Producto: " + productogondola.Nombre + " cantidad: " + productogondola.Cantidad);
            }
        }
        public void CompraVenta(Cliente cliente)
        {
            foreach (Producto producto1 in cliente.CarritodeCompras)
            {
                foreach (Producto producto2 in ListaDeProductos)
                {
                    if (producto1.Nombre == producto2.Nombre && producto1.Cantidad <= producto2.Cantidad)
                    {
                        totalCompra = (producto2.Precio * producto1.Cantidad);
                        totalPagar = (totalCompra * cliente.Descuento);
                        Console.WriteLine("Compra realizada");
                    }
                    else
                    {
                        Console.WriteLine("No puede realizarse la compra");
                    }



                }
            }
        }

            public void SelecciondeProducto(Producto ProductoASeleccionar, int cantidad)
            {
                cliente.SelecciondeProducto(ProductoASeleccionar, cantidad);
            }


            public void ProductosdelCarrito(Cliente cliente)
            {
                Console.WriteLine("Carrito de compra");
                foreach (Producto productodelcarrito in cliente.CarritodeCompras)
                {
                    Console.WriteLine("Producto: " + productodelcarrito.Nombre + " cantidad: " + productodelcarrito.Cantidad);
                }
            }

    }

}
