using System;

namespace alumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            aula quintoB = new aula();
            quintoB.PasarAlFrente(quintoB.a1);
            quintoB.PasarAlFrente(quintoB.a5);
            quintoB.a5.hablar();
        }
    }
}
