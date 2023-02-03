using System;
using System.Collections.Generic;
using System.Text;

namespace Mercado_Singleton_Builder
{
    class Ubicacion
    {
        public String Nombre_De_La_Calle;
        public int Numeracion;

        public Ubicacion(string Nombre,int Numeracion)
        {
            this.Nombre_De_La_Calle = Nombre;
            this.Numeracion = Numeracion;
        }
    }
}
