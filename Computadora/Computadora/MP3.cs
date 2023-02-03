using System;
using System.Collections.Generic;
using System.Text;

namespace Computadora
{
    public class MP3 : Archivo 
    {
        public override void Sonar(string _name)
        {
            Console.WriteLine("Sonando MP3");
        }
        public MP3(string _name)
        {

        }
    }
}
