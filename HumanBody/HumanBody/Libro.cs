using System;
using System.Collections.Generic;
using System.Text;

namespace HumanBody
{
    class Libro : Objeto
    {
        public Libro(float kg) : base(kg)
        {
            peso = kg;
        }
    }
}
