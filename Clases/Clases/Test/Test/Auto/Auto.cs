using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Auto
{
    /*Implementa la interfaz de auto
    *se podria haber utilizado la misma interfaz de motor pero lo correcto es esta ya que en otra ocasion 
    *podrian tener metodos diferentes*/
    public class Auto : IAuto
    {
        //Como propeiedades del auto (pertenencias) está el moto y el tanque de combustible
        public Motor motor;
        public Tanque tanque;
        public Radiador radiador;
        
        public Auto()
        {
            /*En el constructor de motor estamos indicando que cuando creamos el objeto AUTO
             * también creamos un motor simultaneamente y un tanque de combustible*/
            motor = new Motor(this);
            tanque = new Tanque();
            radiador = new Radiador();
            
        }

        public void Arrancar()
        {
            /*Motor tiene su propio método ARRANCAR (que a su vez hace arrancar a los pistones mediante sus propio metodo ARRANCAR
             *De esta manera, una vez arrancado el auto, arranca el motor y los pistones*/
            motor.Arrancar();
        }
        
        public void CargarCombustible(int cantidadDeLitrosQueDeseaCargar)
        {
            tanque.CargarCombustible(cantidadDeLitrosQueDeseaCargar);
        }

        public void ExplotoPiston(double efiCombustible)
        {
            tanque.ConsumirCombustible(efiCombustible);
        }
        public void bajartemperaturamotor()
        {
            radiador.bajartemperaturamotor();
        }
    }
}
