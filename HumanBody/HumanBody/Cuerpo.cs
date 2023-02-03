using System;
using System.Collections.Generic;
using System.Text;

namespace HumanBody
{
    class Cuerpo
    {
        public Cabeza cabeza;
        public Pie pie;
        public Mano manoD;
        public Mano manoI;
        public Cuerpo()
        {
            manoD = new Mano(5, true);
            manoI = new Mano(10, false);
        }
        /*public void agarrar(Objeto objetoagarrado)
        {
            Mano.agarrar(objetoagarrado);
                
        }
        public void patear(Objeto objetoAPatear)
        {
            pie.patear(objetoAPatear);
        }*/
        public void agarrar(Objeto obj)
        {
            {
                if (manoD.Fuerza >= manoI.Fuerza)
                {
                    if (manoI.stateMano == false)
                    {
                        if (obj.peso <= manoI.Fuerza)
                        {
                            manoI.agarrar(obj);
                            manoI.stateMano = true;
                            Console.WriteLine(" Agarrado con la mano izquierda");
                        }
                        else
                        {
                            if (manoD.stateMano == false)
                            {
                                if (obj.peso <= manoD.Fuerza)
                                {
                                    manoD.agarrar(obj);
                                    manoD.stateMano = true;
                                    Console.WriteLine(" Agarrado con la mano derecha");
                                }
                                else
                                {
                                    if (obj.peso <= (manoD.Fuerza + manoI.Fuerza))
                                    {
                                        manoD.soltarObjeto();
                                        manoI.agarrar(obj);
                                        manoD.agarrar(obj);
                                        Console.WriteLine("Agarrando con las dos manos");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Excede el peso");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ambas manos ocupadas"); 
                            }

                        }
                    }

                    else
                    {
                        if (manoD.stateMano == false)
                        {
                            if (obj.peso <= manoD.Fuerza)
                            {
                                manoD.agarrar(obj);
                                manoD.stateMano = true;
                                Console.WriteLine(" Agarrado con la mano derecha");
                            }
                            else
                            {
                                if (obj.peso <= (manoD.Fuerza + manoI.Fuerza))
                                {
                                    manoI.soltarObjeto();
                                    manoI.agarrar(obj);
                                    manoD.agarrar(obj);
                                    Console.WriteLine("Agarrando con las dos manos");
                                }
                                else
                                {
                                    Console.WriteLine("Excede el peso");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ambas manos ocupadas");
                        }
                    }

                }
                else 
                {
                    if (manoD.stateMano == false)
                    {
                        if (obj.peso <= manoD.Fuerza)
                        {
                            manoD.agarrar(obj);
                            manoD.stateMano = true;
                            Console.WriteLine(" Agarrado con la mano izquierda");
                        }
                        else
                        {
                            if (manoI.stateMano == false)
                            {
                                if (obj.peso <= manoD.Fuerza)
                                {
                                    manoI.agarrar(obj);
                                    manoI.stateMano = true;
                                    Console.WriteLine(" Agarrado con la mano derecha");
                                }
                                else
                                {
                                    if (obj.peso <= (manoI.Fuerza + manoD.Fuerza))
                                    {
                                        manoI.soltarObjeto();
                                        manoD.agarrar(obj);
                                        manoI.agarrar(obj);
                                        Console.WriteLine("Agarrando con las dos manos");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Excede el peso");
                                    }
                                }
                            }

                        }
                    }

                    else
                    {
                        if (manoI.stateMano == false)
                        {
                            if (obj.peso <= manoD.Fuerza)
                            {
                                manoI.agarrar(obj);
                                manoI.stateMano = true;
                                Console.WriteLine(" Agarrado con la mano derecha");
                            }
                            else
                            {
                                if (obj.peso <= (manoI.Fuerza + manoD.Fuerza))
                                {
                                    manoD.soltarObjeto();
                                    manoD.agarrar(obj);
                                    manoI.agarrar(obj);
                                    Console.WriteLine("Agarrando con las dos manos");
                                }
                                else
                                {
                                    Console.WriteLine("Excede el peso");
                                }
                            }
                        }
                        else 
                        {
                            Console.WriteLine("Ambas manos ocupadas");
                        }
                    }
                }

            }
        }
    }
}