using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Auto
{
    public abstract class Tanque
    {
        public double Capacidad_De_Carga;
        public double Eficiencia;
        public double Cargado;

        public Tanque(double Capacidad_De_Carga_ ,double Eficiencia_)
        {
            this.Cargado = 100;
        }
        public virtual void CargarCombustible(int cantidadDeLitrosQueDeseaCargar)
        {
            if (Capacidad_De_Carga >= cantidadDeLitrosQueDeseaCargar)
            {
                Cargado = cantidadDeLitrosQueDeseaCargar;
            }
            else
            {
                Cargado = Capacidad_De_Carga;
            }
        }

        public virtual void ConsumirCombustible(double efiCombustible)
        {
            Capacidad_De_Carga = (Capacidad_De_Carga - efiCombustible);
        }
    }
}
