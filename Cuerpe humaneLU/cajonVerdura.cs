using System;
using System.Collections.Generic;
using System.Text;

namespace Cuerpe_humaneLU
{
    class CajonDeVerduras : Objetos
    {
        double peso;
        string tipo;
        public CajonDeVerduras()
        {
            peso = 15.0;
            tipo = "cajon de verduras";
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
