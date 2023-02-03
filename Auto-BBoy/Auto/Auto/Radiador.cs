using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Auto
{
    public class Radiador
    {
        private double eficiencia;
        private IMotor Motor;
        public Radiador(IMotor A)
        {
            this.eficiencia = 0.5;
            this.Motor = A;


        }
        public void DescontarTemp()
        {
            this.Motor.TemperaturaDesc();
        }

    }
}
