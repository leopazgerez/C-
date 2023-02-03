using System;
using System.Collections.Generic;
using System.Text;

namespace Comunicacion_con_Handys
{
    public class Frecuencia
    {
        public Mensaje mensaje;
        public Mensaje mensajeVacio;
        public Frecuencia()
        {
            this.mensajeVacio = new Mensaje("...", 0);
            this.mensaje = mensajeVacio;
        }

        public void Mensaje(Mensaje _mensaje)
        {
            this.mensaje= _mensaje;
        }

    }
}
