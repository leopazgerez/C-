using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Auto
{
    public class PistonB : Piston
    { 
        //Si la clase padre tiene en su constructor parametros, los hijos que hereden deben pasarle esos parametros
        public PistonB(IMotor _motor) : base(_motor)
        {
            /*Como las propiedades son heredadas de la clase padre, lo que se debe hacer en sus hijos son
             * definirlas y para ser especificos y correctos, se debe hace uso de la palabra clave THIS*/
            this.eficienciaCombustible = 0.5;
            this.eficienciaTemperatura = 0.5;
        }
    }
}
