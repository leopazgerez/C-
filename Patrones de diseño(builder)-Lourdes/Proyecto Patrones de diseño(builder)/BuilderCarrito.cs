using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Patrones_de_diseño_builder_
{
    class BuilderCarrito
    {
        private Carrito carrito = new Carrito();

        public void crearCliente()
        {
            carrito.agregarCliente(new Cliente("Juan", 22000111)); 
        }

        public void crearLista()
        {
            carrito.agregarLista(new ListaDeCompra());
        }

        public void crearMedioDePago()
        {
            carrito.agregarMedioDePago(new MedioDePago()); 
        }

        public Carrito ProductoFinal()
        {
            return carrito; 
        }
    }
}
