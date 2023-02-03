using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Auto
{
    public abstract class Piston
    {
        //Creo una propiedad de tipo interfaz que cumple la implementacion del método definido en la interfaz
        //De esta manera guardo en referencia a motor que es regida estricamtente bajo interfaz
        private IMotor motor;

        protected double eficienciaTemperatura;
        protected double eficienciaCombustible;

        public Piston(IMotor _motor)
        {
            //Le pido a piston que me pase por parametro un motor a quien le voy a pasar por referencia mi motor
            motor = _motor;
        }

        public void Arrancar()
        {
            //Tiene el método arrancar que cuando el motor arranque, va a dar 100 vueltas hasta explotar
            for (int i = 0; i < 100; i++)
            {
                //SI O SI NECESITO UNA INSTANCIA DE MOTOR DENTRO DE LA CLASE PISTON PARA PODER AVISARLE AL MOTOR QUE EXPLOTÉ
                motor.ExplotoPiston(this.eficienciaTemperatura, this.eficienciaCombustible);
            }
        }
    }
}
