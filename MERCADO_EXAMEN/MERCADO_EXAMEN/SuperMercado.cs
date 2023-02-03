using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MERCADO_EXAMEN
{
    class SuperMercado: IMercado
    {
        private List<Producto> Lista_Productos;
        private List<Cliente> Lista_Clientes_Preferenciales;
        private List<Cliente> Lista_Compras;

        private double balance;
        public SuperMercado()
        {
            this.Lista_Productos = new List<Producto>();
            this.Lista_Clientes_Preferenciales = new List<Cliente>();
            this.Lista_Compras = new List<Cliente>();
            Cliente Jaimito1 = new Cliente("Pepe", 1, this);
            Cliente Jaimito2 = new Cliente("Pepote", 5, this);
            Cliente Jaimito3 = new Cliente("Pepito", 3, this);
            Cliente Jaimito4 = new Cliente("Pepito", 7, this);
            Cliente Jaimito7 = new Cliente("Pepito", 100, this);
            this.Lista_Clientes_Preferenciales.Add(Jaimito1);
            this.Lista_Clientes_Preferenciales.Add(Jaimito2);
            this.Lista_Clientes_Preferenciales.Add(Jaimito3);
            this.Lista_Clientes_Preferenciales.Add(Jaimito4);
            this.Lista_Clientes_Preferenciales.Add(Jaimito7);

            this.balance = 0;

        }
        public void Mostrar_Productos()
        {
            Console.WriteLine("LISTADO DE PRODUCTOS DEL SUPER-MERCADO");
            foreach(Producto _Producto in Lista_Productos)
            {
                if (_Producto.Stock != 0)
                {
                    Console.WriteLine(_Producto);
                }
            }
        }
        public bool VerificarStockCompleto(List<Producto> Carrito)
        {
            bool EfectuarCompra = true;
            foreach (Producto _producto in Carrito)
            {
                int i = 0;
                while (_producto != Lista_Productos.ElementAt(i) && EfectuarCompra != false)
                {
                    i++;
                }
                if (_producto.Stock > Lista_Productos.ElementAt(i).Stock)
                {
                    EfectuarCompra = false;
                }
            }
            return EfectuarCompra;
        }
        public bool Verificar_Cliente_Preferencial(int DNI)
        {
            bool Confirmacion=false;
            foreach(Cliente Preferencial in Lista_Clientes_Preferenciales)
            {
                if (Preferencial.DNI == DNI)
                {
                    Confirmacion = true;
                }

            }
            return Confirmacion;
        }
        public void Comprar(Cliente _Cliente)
        {
            if (VerificarStockCompleto(_Cliente._Carrito.Lista_Productos))
            {
                
                foreach (Producto _producto in _Cliente._Carrito.Lista_Productos)
                {
                    int i = 0;
                    while (_producto != Lista_Productos.ElementAt(i))
                    {
                        i++;
                    }
                    Lista_Productos.ElementAt(i).Stock -= _producto.Stock;
                    this.balance += Lista_Productos.ElementAt(i).Precio * _producto.Stock;

                }
                Lista_Compras.Add(_Cliente);

            }
            else
            {
                Console.WriteLine("No se puede Efectuar la compra ya que uno de sus productos no esta en stock");
            }

        }
        public List<Producto> MisProductos()
        {
            return this.Lista_Productos;
        }
        public List<Cliente> MisClientesPreferenciales()
        {
            return this.Lista_Clientes_Preferenciales;
        }
        public void Agregar_Productos_A_Mi_Mercado(Producto NuevoPorducto)
        {
            this.Lista_Productos.Add(NuevoPorducto);
        }
        
    }

}
