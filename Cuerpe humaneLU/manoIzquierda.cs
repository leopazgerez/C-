using System;
using System.Collections.Generic;
using System.Text;

namespace Cuerpe_humaneLU
{
    class ManoIzquierda : IAccionManos
        {
            private double pesoResistencia;
            private Objetos objetoAgarrar;
            private bool manoVacia;
            public ManoIzquierda()
            {
                pesoResistencia = 5.0;
                manoVacia = true;
            }
            public void agarrar(Objetos objeto, double peso)
            {
                    objetoAgarrar = objeto;
                    manoVacia = false;
            }

            public void soltar()
            {
                objetoAgarrar = null;
                manoVacia = true;
            }
        }
}
