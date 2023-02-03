using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Auto
{
    public interface IMotor
    {
        /*Se crea la interface para poder usar como medio de comunicacion inversa entre el piston y motor
         * haciendo que este (piston) le avise a motor que explotó.
         * Asi le brinda más seguridad al codigo que creando una instancia de motor dentro de la clase piston, lo que
         * permitiria el acceso completo a las caracteristicas de motor*/
        void ExplotoPiston(double efiTemperatura, double efiCombustible);
        void bajartemperaturamotor(double _eficienciaderadiador);
    }
}
