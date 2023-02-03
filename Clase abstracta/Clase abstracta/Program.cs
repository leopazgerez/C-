using System;

namespace Clase_abstracta
{
    class Program
    {
        static void Main(string[] args)
        {
            Servivo Pino = new Planta();
            Servivo Perro = new AnimalCarnivoro();
            Servivo Vaca = new AnimalHerviboro();

            Pino.Alimentarse();
            Perro.Alimentarse();
            Vaca.Alimentarse();
            IServivito Lapacho = new Vegetal();
            IServivito Perro1 = new AnimalCarnicero();
            IServivito Carnero = new AnimalYuyero();

            Lapacho.Comer();
            Perro1.Comer();
            Carnero.Comer();

        }
    }
}
