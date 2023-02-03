using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Auto
{
    public interface IAuto
    {
        /*Se crea esta interfaz con el mismo proposito que la de motor, para poder realizar una retroalimentacion y comunicarse 
        Motor a auto*/
        void ExplotoPiston(double efiCombustible);
        void bajartemperaturamotor();
    }
}
