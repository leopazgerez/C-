using System;
using System.Collections.Generic;
using System.Text;

namespace Mercado_Singleton_Builder
{
    interface IBuilder
    {
        public void AgregarProducto(Producto _Producto,int _Cantidad);
        public void FormaDePago(string _Forma_De_Pago);
        public void Cliente(Cliente _Cliente);
        public void DireccionDeEntrega(String Nombre, int Numeracion);
        public void MostrarTotal();
        public void ResetCompra(ICarrito);
        public void Descuento(int _descuento);
        public void TotalDelDescuento();
    }
}
