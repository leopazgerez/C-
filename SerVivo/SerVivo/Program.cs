using System;

namespace SerVivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Perro perro = new Perro("Lola");
            perro.getNombre();
            string nombre = perro.getNombre();
            Console.WriteLine(nombre);

        }
    }
}
