using System;

namespace Supermercado2
{
    class Program
    {
        static void Main(string[] args)
        {
            //creo el super
            Supermercado mercado = new Supermercado();
            //Agrego productos
            mercado.Productosdisponibles.Add(new Producto("Lavandina", 123, 159.99, 15));
            mercado.Productosdisponibles.Add(new Producto("Jabon", 345, 59.99, 30));
            mercado.Productosdisponibles.Add(new Producto("Cepillo", 678, 180.99, 10));
            //Vemos productos disponibles
            mercado.Productosengondola();
            //creamos clientes
            Cliente cliente1 = new Cliente("Mario", mercado, 222);
            Cliente cliente2 = new Cliente("Enrique", mercado, 432);
            //seleccionamos productos deseados





        }
    }
}
