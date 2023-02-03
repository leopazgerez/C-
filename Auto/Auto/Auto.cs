using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Auto
{
    public class Auto : IAuto
    {
        public Motor motor;
        public TanqueNafta tanqueNafta;
        public Radiador radiador;
        public TanqueGNC tanqueGNC;
        public Auto()
        {
            motor = new Motor(this);
            tanqueNafta = new TanqueNafta();
            tanqueGNC = new TanqueGNC();
            radiador = new Radiador(this.motor);
        }

        public void Arrancar()
        {
            motor.Arrancar();
        }
        
        public void CargarCombustible(double cantidadDeLitrosQueDeseaCargar)
        {
            tanqueNafta.CargarCombustible(cantidadDeLitrosQueDeseaCargar);
            tanqueGNC.CargarCombustible(cantidadDeLitrosQueDeseaCargar);
        }

        public void ExplotoPiston()
        {
            //lo que desencadena el consumo de combustible es la explosion de piston por lo que dentro del metodo explotar deberia estar la algoritmia 
            
        }
        public void ActivarRadiador()
        {
            this.radiador.DescontarTemp();
        }
       
    }
}
