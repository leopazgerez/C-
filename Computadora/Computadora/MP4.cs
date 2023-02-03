using System;
using System.Collections.Generic;
using System.Text;

namespace Computadora
{
   public class MP4 : Archivo
    {
        public override void Reproducir(string _name)
        {
            Console.WriteLine("Reproduciendo un MP4");
        }
        public MP4(string _name)
        {

        }
    }
}
 