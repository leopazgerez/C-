using System;
using System.Collections.Generic;
using System.Text;

namespace Computadora
{
    public class PDF : Archivo
    {
        public override void Mostrar(string _name)
        {
            Console.WriteLine("Mostrando PDF");
        }
        public PDF(string _name)
        {

        }
    }
}
