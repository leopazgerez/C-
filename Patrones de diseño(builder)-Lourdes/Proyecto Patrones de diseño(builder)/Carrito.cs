using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Patrones_de_diseño_builder_
{
    public class Carrito
    {
        private IlistaDeCompra listaDeCompra;
        private Icliente cliente;
        private ImedioDePago medioDePago; 
        
        public void agregarLista(IlistaDeCompra lista)
        {
            listaDeCompra = lista;
            Console.WriteLine("tu carrito contiene los siguientes productos");
            lista.getLista();
        }

        public void agregarCliente(Icliente icliente)
        {
            cliente = icliente;
            Console.WriteLine(icliente.infoCliente()); 
        }

        public void agregarMedioDePago(ImedioDePago imedio)
        {
            medioDePago = imedio;
            Console.WriteLine("Vas a pagar con" + medioDePago.getMedioPago());
        }



    }
}
