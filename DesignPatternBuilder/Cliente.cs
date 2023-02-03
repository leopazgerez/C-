using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternBuilder
{
    public class Cliente
    {
        public Direccion Direccion;
        private string Nombre;
        private int ID;

        public Cliente(string nombre, int id, Direccion direccion) 
        {
            Nombre = nombre;
            ID = id;
            Direccion = direccion;
        }
    }
}
