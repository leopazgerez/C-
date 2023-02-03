using System;
using System.Collections.Generic;
using System.Text;

namespace Computadora
{
    public abstract class Archivo
    {
        public string name;
        public virtual void Sonar(string _name)
        {
            Console.WriteLine("NO COMPATIBLE");
        }
        public virtual void Mostrar(string _name)
        {
            Console.WriteLine("NO COMPATIBLE");
                    }
        public virtual void Reproducir(string _name)
        {
            Console.WriteLine("NO COMPATIBLE");
        }
        public Archivo()
        {
          
        }

    }
}
