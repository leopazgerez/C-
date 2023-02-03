using System;

namespace Supermercado
{
    class Program
    {
        static void Main(string[] args)
        {
            //crea supermercado
            Supermercado super = new Supermercado();
            //cargar productos al supermercado
            Lavandina lavandina = new Lavandina("Lavandina", 300, 2);
            GalletasSaladas galletas = new GalletasSaladas("Galletas saladas", 149, 20);
            JabonEnPolvo jabon = new JabonEnPolvo("Jabon en Polvo", 477, 5);
            Producto[] ProductosDelSuper = { lavandina, galletas, jabon };
            super.ListaDeProductos.AddRange(ProductosDelSuper);
            //Creamos Clientes
            Cliente cliente1 = new Cliente(super, "Enrique", 1);
            Cliente cliente2 = new Cliente(super, "Paul", 0.1);
            //vemos productos disponibles
            super.ProductosDisponibles();
            //Seleccionamos productos deseados
            cliente1.SelecciondeProducto(lavandina, 2);
            cliente1.SelecciondeProducto(galletas, 4);
            //realiza compra
            super.CompraVenta(cliente1);

        }
    }
}
