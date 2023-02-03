using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Auto
{
    public class PistonB : Piston
    {
        public PistonB(IMotor _motor) : base(_motor)
        {
            this.eficienciaCombustible = 0.5;
            this.eficienciaTemperatura = 0.5;
        }
    }
}
