using System;
using System.Collections.Generic;
using System.Text;

namespace HumanBody
{
    class Test
    {
        static void Main(string[] args)
        {
            Cuerpo cuerpo = new Cuerpo();
            //Libro Libro = new Libro();
           // Mano manoD = new Mano(5, true);
            //Mano manoI = new Mano(10, false);
            Libro libro = new Libro(3);
            //Celular cell = new Celular(3);
            //Vaso vaso = new Vaso(15);
            Celular cell2 = new Celular(15);
            cuerpo.agarrar(libro);
            //cuerpo.agarrar(cell);
            cuerpo.agarrar(cell2);

        }
    }
}
