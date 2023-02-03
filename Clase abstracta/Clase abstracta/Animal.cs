using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_abstracta
{
    public abstract class Animal : Servivo
    {
    }
    public class Animal1 : IServivito
    {
        public void Comer()
        {
            Console.WriteLine("Yo como a costas de otro");
        }
    }   
}
