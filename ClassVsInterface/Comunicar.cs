using System;
using System.Collections.Generic;
using System.Text;

namespace ClassVsInterface
{
    public abstract class Comunicar
    {
        /*Métodos abstractos no tienen implementacion dentro de la clase abstracta (cuerpo) y obliga a las 
         * clases hijas (o sea las que hereden) que los sobreescriban e implementen el método*/
        public abstract void Hablando();
        /*Los métodos virtuales proveen de implementación dentro de la clase abstracta, permitiendo 
         * la sobreescritura o no dentro de las clases hijas al momento de la herencia.
         * En caso de no haber sobreescritura, se implementa el metodo del padre*/
        public virtual void Hablar()
        {
            Console.WriteLine("No hablo");
        }
    }
}
