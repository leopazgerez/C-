using System;
using System.Collections.Generic;
using System.Text;

namespace Cuerpe_humaneLU
{
    class ManoDerecha : IAccionManos
    {
            private double pesoResistencia;
            private Objetos objetoAgarrar;
            private bool manoVacia;
            public ManoDerecha()
            {
                pesoResistencia = 5.0;
                manoVacia = true;
            }
            public void agarrar(Objetos objeto, double peso)
            {
                objetoAgarrar = objeto;
                if (peso <= pesoResistencia && manoVacia == true)
                {
                    Console.WriteLine($"Agarrando {objeto} con la mano izquierda. ");
                    manoVacia = false;

                }
                else if (peso > pesoResistencia) Console.WriteLine($"{objeto} demasiado pesado para la mano izquierda");
                else Console.WriteLine($"Mano izquierda ocupada, ahora no puede agarrar {objeto}.");

            }

            public void soltar()
            {
                Console.WriteLine($"Soltando {objetoAgarrar} en la mano izquierda. ");
            }
        }
    }
