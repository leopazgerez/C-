using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Auto
{
    public class Radiador
    {
        public double eficiencia;
        private IMotor Motor;
        public Radiador(IMotor delauto)
        {
            this.eficiencia = 0.5;
            this.Motor = delauto;


        }
        public void DescontarTemp()
        {
            this.Motor.TemperaturaDesc(this.eficiencia);
        }

    }
}
