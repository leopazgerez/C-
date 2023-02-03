using System;
using System.Collections.Generic;
using System.Text;

namespace HumanBody
{
    class Mano 
    {
        public Objeto Objeto;
        public float Fuerza;
        public bool stateMano;
        public bool ManoD = true;

        public Mano(float kg, bool manoD)
        {
            Fuerza = kg;
            ManoD = manoD;
            stateMano = false;
        }
        public void agarrar(Objeto obj)
        {
            Objeto = obj;
            stateMano = true;
        }
        public void soltarObjeto()
        {
            Objeto = null;
            stateMano = false;
        }
        
    }
}
