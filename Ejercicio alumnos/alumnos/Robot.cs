using System;
using System.Collections.Generic;
using System.Text;

namespace alumnos
{
    class Robot : IHablar
    {
        public Robot()
        { 

        }
        public void hablar()
        {
            Console.WriteLine("Hablando como Robot");
        }
    }
}
