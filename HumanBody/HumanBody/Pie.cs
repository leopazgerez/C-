using System;
using System.Collections.Generic;
using System.Text;

namespace HumanBody
{
    class Pie
    {
        public bool pieD = true;
        public Objeto objetopateado;
        public Pie()
        {

        }
        public void patear(Objeto objetoAPatear)
        {
            objetopateado = objetoAPatear;
        }
    }
}
