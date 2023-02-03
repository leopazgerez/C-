using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Patrones_de_diseño_builder_
{
    public class Super 
    {
        private int ventasRealizadas;
        private double saldoDisponible;
        private int stockProductos;
        private double descuentoProducto;
        IlistaDeCompra listaProductos; 

        List<Producto> listaDeProductos = new List<Producto>();

        Cliente clientePreferencial;
        Cliente clienteCorriente;
        public Super()
        {
            ventasRealizadas = 0;
            saldoDisponible = 0;
            descuentoProducto = 0; 

        }

        public void setProductos(Producto productos, int stock, int descuento)
        {
            listaDeProductos.Add(productos);
            stockProductos = stock;
            descuentoProducto = descuento;

        }

        public void getProductos()
        {
            Console.WriteLine($"¡Bienvenido a PowerUpSuper!\n A continuacion veras nuestros productos disponibles ");

            foreach (Producto producto in listaDeProductos)
            {
                Console.WriteLine(producto.getInfoProductos() + "\n stock:" + stockProductos + "\n descuento: % " + descuentoProducto);

            }

        }

        public void compraCliente(Producto[] lista)//pasar por parametro la lista
        {
            for (int i = 0; i < lista.Length; i++)
            {

                //preguntar si el producto tiene descuento si lo tiene aplicar descuento y sumar el precio a saldoapagar
                //
                // luego preguntar si es cliente preferencial si lo es aplicar descuento sobre el saldoapagar
                //si no solo mostrar saldoapagar
            }
        }

        public void Vender(double total) //pasar el saldoapagar por parametro
        {

            double totalCompra = total;
            saldoDisponible += totalCompra;
            Console.WriteLine("Gracias por tu compra");
            ventasRealizadas++;
        }
    }
}
