using System;
using System.Collections.Generic;
using System.Text;

namespace MERCADO_EXAMEN
{
    class Cliente
    {
        private String Nombre;
        public int DNI;
        public Carrito _Carrito;
        public IMercado MiMercado;
        
        public Cliente(String Nombre,int DNI,IMercado MiMercado)
        {
            this._Carrito = new Carrito();
            this.Nombre = Nombre;
            this.DNI = DNI;
            this.MiMercado = MiMercado;
        }
       /*Este seria por si queremos que el usuario cree un tipo producto ya que esta viendo el producto q ofrece el 
        * mercado y pos tiene q anotar tal  cual esta en el supermercado ,suponiendo que no sea tramposo y le quiera
        * poner descuento a todo....
        * 
        * public void Seleccionar(Producto _Producto)
        {
            this._Carrito.Agregar(_Producto);
        }*/
        public void Agregar_A_Lista_De_Compras(String MiProducto,int MiCantidad)
        {
            foreach(Producto _Producto in MiMercado.MisProductos())
            {
                if (_Producto.Stock != 0)
                {

                    if (_Producto.Nombre == MiProducto)
                    {
                        _Producto.Stock = MiCantidad;
                        this._Carrito.Agregar(_Producto);
                    }
                }
            }

        }
        public void Mostrar_Productos()
        {
            Console.WriteLine("MI(" + this.Nombre + ") LISTA DE PRODUCTOS ");

            foreach (Producto _Producto in this._Carrito.Lista_Productos)
            {
                if (_Producto.Stock != 0)
                {
                    Console.WriteLine(_Producto);
                }
            }
            Console.WriteLine("El precio total de la lista es : " + this._Carrito.PrecioTotal);
        }
        public void FinalizarLista()
        {
            foreach(Cliente _Cliente in MiMercado.MisClientesPreferenciales())
            {
                if (_Cliente.DNI == this.DNI)
                {
                    this._Carrito.PrecioTotal -= (this._Carrito.PrecioTotal / 10);
                }
            }
        }
        public void Mostrar_Mi_Saldo()
        {
            Console.WriteLine("El precio Total de Mi Lista es :"+this._Carrito.PrecioTotal);
        }
        /*Otra Opcion para hacer un Selecciona con menos posibilidades de falla seria hacer un swtich y pedir por 
         * sistema q entren un nro... suponiendo q podemos enumerar todos los productos y asi seleccionar cual y
         * cantidad sin tener q depender de que el usuario escriba bien lo que quiere o cree un producto q no esta,y 
         * pedir por consola q escriban 1 nro*/
    }
}
