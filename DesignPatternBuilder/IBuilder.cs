using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternBuilder
{
    interface IBuilder
    {
        public CompraBuilder Item(Item producto);

        public CompraBuilder Client(Cliente cliente);

        public CompraBuilder Direction(Direccion DirDeEnv);

        public CompraBuilder DirectionClient(Cliente cliente);

        public CompraBuilder Pago(IMetodoDePago MetDePag);

        public CompraBuilder Constructor();
      
    }
}
}
