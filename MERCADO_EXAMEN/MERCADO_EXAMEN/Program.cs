using System;

namespace MERCADO_EXAMEN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SuperMercado Super = new SuperMercado();

            Producto Harina = new Producto("HarinaTrigal", 1, 10, 5, 10);
            Producto Cereal = new Producto("Cereal", 5, 6, 3, 50);
            Producto Yogur = new Producto("Yogur", 10, 0.5, 1000, 0);
            Super.Agregar_Productos_A_Mi_Mercado(Yogur);
            Super.Agregar_Productos_A_Mi_Mercado(Cereal);
            Super.Agregar_Productos_A_Mi_Mercado(Harina);
            Super.Mostrar_Productos();
            Cliente Pepito1 = new Cliente("Pepe", 1, Super);
            Cliente Pepito2 = new Cliente("Pepote", 2, Super);
            Cliente Pepito3 = new Cliente("Pepito", 3, Super);
            Pepito1.Agregar_A_Lista_De_Compras("HarinaTrigal", 3);
            Pepito1.Mostrar_Productos();
            Pepito1.Mostrar_Mi_Saldo();
        }
    }
}
