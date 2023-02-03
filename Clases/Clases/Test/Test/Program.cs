using System;

namespace Test.Auto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Auto auto = new Auto();

            auto.CargarCombustible(150);
            auto.Arrancar();
            auto.ExplotoPiston(1);
            
            

        }
    }
}
