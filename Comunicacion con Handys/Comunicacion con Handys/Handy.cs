using System;
using System.Collections.Generic;
using System.Text;

namespace Comunicacion_con_Handys
{
    public class Handy
    {
        public Frecuencia frecuencia;
        public Mensaje miMensaje;
        public int ID;
        public Handy(Frecuencia _frecuencia, int _ID)
        {
            this.frecuencia = _frecuencia;
            this.ID = _ID;
        }

        public void CambiarFrecuencia(Frecuencia _frecuencia)
        {
            this.frecuencia = _frecuencia;
        }


        public void Hablar(string texto)
        {
            miMensaje = new Mensaje(texto, this.ID);
            this.frecuencia.Mensaje(miMensaje);
        }


        public void Escuchar()
        {
            if ((frecuencia.mensaje.emisor) != (this.ID)){
                frecuencia.mensaje.Trasmitir();
            }else {
                Console.WriteLine(frecuencia.mensajeVacio.texto);
            }
        }
    }
}
