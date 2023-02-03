using System;

namespace Comunicacion_con_Handys
{
    class Program
    {
        static void Main(string[] args)
        {
            Mundo mundo = new Mundo();

            mundo.handi1.Escuchar();
            mundo.handi1.Hablar("Hola,hola, probando...");
            mundo.handi1.Escuchar();
            mundo.handi2.Escuchar();
            mundo.handi3.Escuchar();
            mundo.handi2.Hablar("1, 2, 3, hola, probando...");
            mundo.handi2.Escuchar();
            mundo.handi1.Escuchar();
        }
    }
}
