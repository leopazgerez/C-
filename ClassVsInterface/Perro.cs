using System;
using System.Collections.Generic;
using System.Text;

namespace ClassVsInterface
{
    class Perro : Comunicar
    {
        //Método abstracto
        //PALABRA CLAVE A LA HORA DE SOBREESCRIBIR UN METODO ABSTRACTO O VIRTUAL: Override
        public override void Hablando()
        {
       
        }
        //Método virtual
        public override void Hablar()
        {
            Console.WriteLine("Wow");
        }
        public Perro()
        {

        }
    }
}
