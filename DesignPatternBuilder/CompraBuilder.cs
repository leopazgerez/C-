using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternBuilder
{
    public class CompraBuilder : IBuilder
    {
        private Item Items;
        private Cliente Cliente;
        private Direccion DireccionDeEnvio;
        private IMetodoDePago MetodoDePago;
        public Compra compra;


        public CompraBuilder Item(Item producto) 
        {
            Items = producto;
            return this;
        }
        public CompraBuilder Client(Cliente cliente)
        {
            Cliente = cliente;
            return this;
        }
        public CompraBuilder Direction(Direccion DirDeEnv)
        {
            DireccionDeEnvio = DirDeEnv;
            return this;
        }
        public CompraBuilder DirectionClient(Cliente cliente)
        {
            DireccionDeEnvio = cliente.Direccion;
            return this;
        }
        public CompraBuilder Pago(IMetodoDePago MetDePag)
        {
            MetodoDePago = MetDePag;
            return this;
        }
        public CompraBuilder Constructor()
        {
                return this;
        }
    }
}
