using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Auto
{
    public class Auto : IAuto
    {
        public Motor motor;
        public Tanque_Nafta Nafta;
        public Tanque_GNC GNC;
        public Radiador Radiador;
        public Tanque Tanque_En_Uso;
        public Caja_De_Cambio _Palanca ;
        enum Combustible{ Nafta,GNC};
        int velocidad;
        
        public Auto()
        {
            motor = new Motor(this);
            Nafta = new Tanque_Nafta(100,1);
            GNC = new Tanque_GNC(100,0.5);
            Tanque_En_Uso = null;
            _Palanca = new Caja_De_Cambio();
            velocidad = 0;


        }

        public void Arrancar()
        {
            if (Tanque_En_Uso != null)
            {
                motor.Arrancar();
                Tanque_En_Uso = Nafta;
            }
            else
            {
               if(Tanque_En_Uso is Tanque_Nafta)
                {
                    if(Tanque_En_Uso.Cargado != 0)
                    {
                        _Palanca.Avanzar(velocidad);
                        motor.Arrancar();
                    }
                    else
                    {
                        if(Nafta.Cargado != 0)
                        {
                            Tanque_En_Uso = Nafta;
                            _Palanca.Avanzar(velocidad);
                            motor.Arrancar();
                        }
                        else
                        {
                            Console.WriteLine("No tenemos combustible en ningun lado");
                        }
                    }
                }
                else
                {
                    if(Tanque_En_Uso is Tanque_Nafta)
                    {
                        if (Tanque_En_Uso.Cargado != 0)
                        {
                            _Palanca.Avanzar(velocidad);
                            motor.Arrancar();
                        }
                        else
                        {
                            if (GNC.Cargado != 0)
                            {
                                Tanque_En_Uso = GNC;
                                _Palanca.Avanzar(velocidad);
                                motor.Arrancar();
                            }
                            else
                            {
                                Console.WriteLine("No tenemos combustible en ningun lado");
                            }
                        }
                    }
                }
            }
            
        }
        
        public void CargarCombustible(int cantidadDeLitrosQueDeseaCargar)
        {
            Tanque_En_Uso.CargarCombustible(cantidadDeLitrosQueDeseaCargar);
        }

        public void ExplotoPiston(double efiCombustible)
        {
            if (Tanque_En_Uso.Capacidad_De_Carga != 0)
            {
                Tanque_En_Uso.ConsumirCombustible((efiCombustible * Tanque_En_Uso.Eficiencia));
            }
            else
            {
                if (GNC.Cargado != 0)
                {
                    Tanque_En_Uso = GNC;
                    Tanque_En_Uso.ConsumirCombustible((efiCombustible * Tanque_En_Uso.Eficiencia));
                }
                else
                {
                    Console.WriteLine("Auto Apagado sin carga en los tanques");
                }
            }
        }
        public void ActivarRadiador()
        {
            this.Radiador.DescontarTemp();
        }

        public void Cambio_De_Marcha(int Marcha_A_Cambiar)
        {
            if(Marcha_A_Cambiar == 0)
            {
                _Palanca.Neutro();
            }
            else
            {
                if(Marcha_A_Cambiar == 1)
                {
                    _Palanca.Avanzar(velocidad);
                }
                else
                {
                    if(Marcha_A_Cambiar==2)
                    {
                        _Palanca.Retroceder(velocidad);
                    }
                }
            }
        }
        public void Freno()
        {
            velocidad = 0;
        }

        public void Cambio_De_Combustible(int Seleccion_De_Tanque)
        {
            if (Seleccion_De_Tanque==(int) Combustible.GNC)
            {
                if (Tanque_En_Uso is Tanque_GNC)
                {
                    Console.WriteLine("Ya estas usando el Tanque de GNC");
                }
                else
                {
                    Tanque_En_Uso = GNC;
                }
            }
            else
            {
                if (Seleccion_De_Tanque== (int)Combustible.Nafta)
                {
                    if (Tanque_En_Uso is Tanque_Nafta)
                    {
                        Console.WriteLine("Ya estas usando el Tanque de Nafta");
                    }
                    else
                    {
                        Tanque_En_Uso = Nafta;
                    }
                }
            }
        }
    }
}
