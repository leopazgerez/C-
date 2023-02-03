using System;
using System.Collections.Generic;
using System.Text;

namespace Supermercado2
{
    class Cliente 
    {
        public string Nombre;
        public ISuper Super;
        public double id_cliente;
        public Cliente(string nombre, ISuper super, double id_Cliente) 
        {
            Nombre = nombre;
            Super = super;
            id_cliente = id_Cliente;
        }
        public void comprar()
        {
            Super.comprar();
        }
    }
}
