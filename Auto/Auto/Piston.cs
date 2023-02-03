using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Auto
{
    public abstract class Piston
    {
        private IMotor motor;

        protected double eficienciaTemperatura;
        public double eficienciaCombustible;

        public Piston(IMotor _motor)
        {
            motor = _motor;
        }

        public void Arrancar()
        {
            for(int i = 0; i < 100; i++)
            {
                motor.ExplotoPiston(this.eficienciaTemperatura, this.eficienciaCombustible);
            }
        }
    }
}
