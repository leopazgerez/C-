using System;
using System.Collections.Generic;
using System.Text;

namespace Comunicacion_con_Handys
{
    public class Mensaje
    {
        public string texto;
        public int emisor;

        public Mensaje(string _texto,  int _emisor)
        {
            this.texto = _texto;
            this.emisor = _emisor;
        }

        public void Trasmitir()
        {
            Console.WriteLine(this.texto);
        }
    }
}
