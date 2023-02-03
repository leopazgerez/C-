using System;
using System.Collections.Generic;
using System.Text;

namespace SerVivo
{
    public class Animal
    {
        private string nombre;

        public Animal(string nom) 
        {
            this.nombre = nom;
        }

        public string getNombre() 
        {
            return nombre;
        }
    }
}
