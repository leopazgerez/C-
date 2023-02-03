using System;
using System.Collections.Generic;
using System.Text;

namespace Mercado_Singleton_Builder
{
    class Carrito: IBuilder
    {
        private List<Item> Listado_Items;
        private Cliente _Cliente;
        private Ubicacion Entrega;
        private String Forma_De_Pago;
        private int _Descuento;
        private double Total_Del_Descuento=0;

        public void AgregarProducto(Producto _Producto,int _Cantidad)
        {
            this.Listado_Items.Add(new Item(_Producto, _Producto.Costo - ((_Producto.Costo / 100) * _Producto.Descuento), _Cantidad));
        }

        public void Cliente(Cliente _Cliente)
        {
            this._Cliente = _Cliente;
        }

        public void Descuento(int _codigo)
        {
            if (_codigo == 1)
            {
                this._Descuento = 20;
            }
            else
            {
                this._Descuento = 0;
            }
        }

        public void DireccionDeEntrega(string Nombre_de_Calle, int Numeracion)
        {
            this.Entrega = new Ubicacion(Nombre_de_Calle, Numeracion);
        }

        public void FormaDePago(string Nombre)
        {
            this.Forma_De_Pago = Nombre;
        }

        public void MostrarTotal()
        {
            double SumaTotal = 0;
           foreach(Item _Item in this.Listado_Items)
            {
                SumaTotal += _Item.getCosto();
            }
            Console.WriteLine("El Costo total de su carrito es de :"+SumaTotal);
        }

        public void ResetCompra(ICarrito MiCarrito)
        {
            MiCarrito.Reset();
        }

        public void TotalDelDescuento()
        {
            foreach (Item _Item in this.Listado_Items)
            {
                this.Total_Del_Descuento += _Item.getCosto();
            }
            this.Total_Del_Descuento -= (this.Total_Del_Descuento / 100) * this._Descuento;
        }
    }
}
