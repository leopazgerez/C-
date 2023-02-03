using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_abstracta
{
    public class Planta : Servivo
    {
        public override void Alimentarse()
        {
            Console.WriteLine("La Planta se alimenta de la fotosintesis");
        }
    }
    public class Vegetal : IServivito
    {
        public void Comer()
        {
            Console.WriteLine("Yo me cocino solo");
        }
    }
}