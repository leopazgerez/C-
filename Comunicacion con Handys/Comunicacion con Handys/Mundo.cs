using System;
using System.Collections.Generic;
using System.Text;

namespace Comunicacion_con_Handys
{
    public class Mundo
    {
        public Handy handi1;
        public Handy handi2;
        public Handy handi3;
        public Frecuencia FM99;
        public Frecuencia FM88;

        public Mundo()
        {
            FM99 = new Frecuencia();
            FM88 = new Frecuencia();
            handi1 = new Handy(FM99, 1);
            handi2 = new Handy(FM99, 2);
            handi3 = new Handy(FM88, 3);
        }

    }
}
