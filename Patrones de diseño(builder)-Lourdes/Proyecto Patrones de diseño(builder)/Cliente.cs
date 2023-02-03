using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Patrones_de_diseño_builder_
{
    public class Cliente: Icliente
    {
        private string nombre;
        private int documento;
        public bool socio;
        

        public Cliente(string nombre, int dni, bool socio = false)
        {
            this.nombre = nombre;
            this.documento = dni;
            this.socio = socio;
        }

        public string infoCliente()
        {
            return "Cliente:" + nombre + "N°DNI:" + documento + "Socio:" + socio; 
        }
       
    }
}
