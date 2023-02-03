using System;
using System.Collections.Generic;
using System.Text;

namespace ClassVsInterface
{
    class Gato : IComunicar
    {
        //Una interfaz al ser un contrato se debe implementar el método.
        public void Hablar()
        {
            Console.WriteLine("meow");
        }
        public Gato()
        {

        }
    }
}
