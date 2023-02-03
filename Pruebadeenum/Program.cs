using System;

namespace Pruebadeenum
{
    class Program
    {
        enum level
        {
            low,
            medium,
            high
        }
        enum color 
        {
            red = -1,
            yellow = 0,
            green = 1
        }

        static void Main(string[] args)
        {
            level dificultad = level.medium;
            Console.WriteLine(dificultad);
            int difficulty = (int)level.low;
            Console.WriteLine(difficulty);
            color semaforo = color.red;
            Console.WriteLine("Semaforo en {-1}");

        }
        
    }
}
