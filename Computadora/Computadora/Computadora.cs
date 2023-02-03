using System;
using System.Collections.Generic;
using System.Text;

namespace Computadora
{
    class Computadora
    {
        List<Archivo> archivos;
        public Computadora()
        {
            archivos = new List<Archivo>();
            archivos.Add(new MP3("uno"));
            archivos.Add(new MP4("dos"));
            archivos.Add(new PDF("tres"));
        }

    }
}
