using System;

namespace Cuerpe_humaneLU
{
    class Program
    {
        static void Main(string[] args)
        { 
            ManoDerecha mano = new ManoDerecha();
            Camperon campera = new Camperon();
            mano.agarrar(campera, 7);
        }
    }
}
