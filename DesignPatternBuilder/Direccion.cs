using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternBuilder
{
    public class Direccion
    {
        private string Ciudad;
        private string Localidad;
        private string Calle;
        private int Numero;

        public Direccion(string ciudad, string localidad, string calle, int numero) 
        {
            Ciudad = ciudad;
            Localidad= localidad;
            Calle = calle;
            Numero = numero;
        }
    }
}
