using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternBuilder
{
    public class Tarjeta : IMetodoDePago 
    {
        public string Nombre;

        public void setMetodoDePago()
        {
            Console.WriteLine("Tarjeta");
        }
    }
}
