using System;
using System.Collections.Generic;
using System.Text;

namespace Cuerpe_humaneLU
{
    class Camperon : Objetos
    {
            double peso;
            string tipo;
            public Camperon()
            {
                peso = 1.5;
                tipo = "camperon";

            }
            public double getPeso()
            {
                return peso;
            }
            public string getTipo()
            {
                return tipo;
            }
        }
}
