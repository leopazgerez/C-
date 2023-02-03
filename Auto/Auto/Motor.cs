// using System;
// using System.Collections.Generic;
// using System.Text;

namespace Test.Auto
{
    public class Motor : IMotor
    {
        private Piston piston1;
        private Piston piston2;
        private Piston piston3;
        private Piston piston4;
        private Piston piston5;

        private IAuto auto;
        private double temperature;

        public Motor(IAuto _auto)
        {
            piston1 = new PistonA(this);
            piston2 = new PistonA(this);
            piston3 = new PistonA(this);
            piston4 = new PistonB(this);
            piston5 = new PistonB(this);

            auto = _auto;
            temperature = 0;
        }

        public void Arrancar()
        {
            piston1.Arrancar();
            piston2.Arrancar();
            piston3.Arrancar();
            piston4.Arrancar();
            piston5.Arrancar();
        }

        public void ExplotoPiston(double efiTemperatura, double efiCombustible)
        {
            temperature = temperature + efiTemperatura;
            auto.ExplotoPiston();
            if (this.temperature == 80)
            {
                auto.ActivarRadiador();
            }
        }
        
        public void TemperaturaDesc(double eficiencia)
        {
            this.temperature *= eficiencia;
        }
        


    }
}
