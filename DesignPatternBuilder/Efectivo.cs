using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternBuilder
{
    public class Efectivo : IMetodoDePago
    {

        public void setMetodoDePago()
        {
            Console.WriteLine("Efectivo");
        }
    }
}
