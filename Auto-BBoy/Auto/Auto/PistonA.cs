using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Auto
{
    public class PistonA : Piston
    {
        public PistonA(IMotor _motor) : base(_motor)
        {
            this.eficienciaCombustible = 1;
            this.eficienciaTemperatura = 1;
        }
    }
}
