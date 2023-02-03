using System;

namespace DesignPatternBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Direccion domicilio = new Direccion("Salta", "Capital", "San Martin", 123);
            Cliente cliente = new Cliente("Leonel", 1234, domicilio);
            Item producto = new Item();
            Item producto1 = new Item();
            CompraBuilder builder = new CompraBuilder().Client(cliente).Item(producto).Item(producto1).DirectionClient(cliente);
            Compra compra = new Compra(builder.Constructor());
        }
    }
}
