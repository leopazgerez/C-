using System;
using System.Collections.Generic;
using System.Text;

namespace Mercado_Singleton_Builder
{
    public sealed class Mercado_Singleton
    {
        private List<Producto> Listado;
        //Declaro el constructor privado para que no se pueda hacer una instancia de la clase de ninguna forma
        //esto nos fuerza a usar GetInstance.(Es la implementacion del la teoria del Singleton )
        private Mercado_Singleton()
        {
            this.Listado = new List<Producto>();

        }

        private static Mercado_Singleton instance;

        //GetInstance : Lo unico que hace este metodo es basicamente Preguntar si ya hay una instancia de la clase
        //Si, no existe una instancia de la clase entonces crea una y la devuelve , sino devuelve la misma.
        public static Mercado_Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Mercado_Singleton();
            }
            return instance;
        } 

        public void Agregar_Producto()
        {

        }
    }
}
