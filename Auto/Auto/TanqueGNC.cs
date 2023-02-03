using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Auto
    {
    public class TanqueGNC
    {
        private double litros;
        public double eficienciaGNC;

        public TanqueGNC()
        {
            litros = 0;
            eficienciaGNC = 0.5;
        }
        public void CargarCombustible( double cantidadDeLitrosQueDeseaCargar)
        {
            litros = cantidadDeLitrosQueDeseaCargar;
        }
        public void ConsumirCombustible() 
        {
                litros = litros - this.eficienciaGNC;
        }
    }
}
   