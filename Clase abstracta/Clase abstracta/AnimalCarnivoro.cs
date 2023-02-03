using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_abstracta
{
    class AnimalCarnivoro : Animal
    {
        public override void Alimentarse()
        {
            Console.WriteLine("Este animal se alimenta de carne");
        }
    }
    public class AnimalCarnicero : Animal1
    {
      
    }

}
