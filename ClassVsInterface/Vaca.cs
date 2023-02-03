using System;
using System.Collections.Generic;
using System.Text;

namespace ClassVsInterface
{
    class Vaca : Comunicar
    {
        //Método abstracto
        public override void Hablando()
        {
            throw new NotImplementedException();
        }
        //En este caso no implemente el método virtual
        public Vaca()
        {

        }
    }
}
