using System;
using System.Collections.Generic;
using System.Text;

namespace Mercado_Singleton_Builder
{
    class Carrito_Singleton: ICarrito
    {
        //Declaro el constructor privado para que no se pueda hacer una instancia de la clase de ninguna forma
        //esto nos fuerza a usar GetInstance.(Es la implementacion del la teoria del Singleton )

        Carrito _Carrito;
        private Carrito_Singleton()
        {
            this.Reset();
            

        }
        private void Reset()
        {
            this._Carrito = new Carrito();
        }

       

        private static Carrito_Singleton instance;

        //GetInstance : Lo unico que hace este metodo es basicamente Preguntar si ya hay una instancia de la clase
        //Si, no existe una instancia de la clase entonces crea una y la devuelve , sino devuelve la misma.
        public static Carrito_Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Carrito_Singleton();
            }
            return instance;
        }

        public void Agregar_Producto()
        {

        }

        void ICarrito.Reset()
        {
            this.Reset();
        }
    }
}
