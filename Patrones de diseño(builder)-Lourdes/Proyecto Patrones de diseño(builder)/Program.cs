using System;

namespace Proyecto_Patrones_de_diseño_builder_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Super super = new Super();
            // cargar productos al super
            Producto producto1 = new Producto("Arroz", 1, 45.5);
            Producto producto2 = new Producto("Arvejas", 2, 64.1);
            Producto producto3 = new Producto("Carne de vaca", 13, 1550.6);
            Producto producto4 = new Producto("Carne de pollo", 14, 655.5);
            super.setProductos(producto1, 5, 0);
            super.setProductos(producto2, 5, 0);
            super.setProductos(producto3, 5, 10);
            super.setProductos(producto4, 5, 15);
            //creamos clientes
            Cliente cliente1 = new Cliente("Juan", 22000111);
            Cliente cliente2 = new Cliente("Maria", 22546123, true);
            //mostreamos productos
            super.getProductos();

        }
    }
}
