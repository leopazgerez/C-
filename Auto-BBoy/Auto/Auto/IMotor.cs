using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Auto
{
    public interface IMotor
    {
        void ExplotoPiston(double efiTemperatura, double efiCombustible);
        void TemperaturaDesc(double eficiencia);
    }
}
