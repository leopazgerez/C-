using System;

namespace Drawing
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Dibujo Lapiz = new Lapiz();
            Dibujo Aerosol = new Aerosol();
            Dibujo Pincel = new Pincel();
            Lapiz.Dibujando();
            Aerosol.Dibujando();
            Pincel.Dibujando();*/
            Lapiz Lapiz = new Lapiz();
            Pincel Pincel = new Pincel();
            IDraw actual = Lapiz;
            actual.StartDraw();
            actual = Pincel;
            actual.StartDraw();
        }
    }
}
