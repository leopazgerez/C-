using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Auto
{
    public class Caja_De_Cambio
    {
        public enum MARCHA { Neutro, Avanzar, Retroceder };
        int Palanca;

        public Caja_De_Cambio()
        {
            Palanca = 0;
        }
        public void Neutro()
        {
            Palanca = 0;
        }
        public void Avanzar(int velocidad)
        {
            if (velocidad == 0)
            {
                if (Palanca != (int)MARCHA.Avanzar)
                {
                    Palanca = 1;
                }
                else
                {
                    Console.WriteLine("Ya estas En Avanzar");
                }
            }
            else
            {
                Console.WriteLine("No puede cambiar de marcha si la velocidad no es 0");
            }

        }
        public void Retroceder(int velocidad)
        {
            if (velocidad == 0)
            {
                if (Palanca != (int)MARCHA.Retroceder)
                {
                    Palanca = 2;
                }
                else
                {
                    Console.WriteLine("Ya estas En Retroceder");
                }
            }
            else
            {
                Console.WriteLine("No puede cambiar de marcha si la velocidad no es 0");
            }
        }
    }
}
