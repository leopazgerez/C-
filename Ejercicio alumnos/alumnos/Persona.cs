using System;
using System.Collections.Generic;
using System.Text;

namespace alumnos
{
    class Persona : IHablar
    {
        public Persona()
        { 
        }
        public void hablar()
        {
            Console.WriteLine("Hablando como Persona");
        }
            
    }
}
