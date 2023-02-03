using System;
using System.Collections.Generic;
using System.Text;

namespace Drawing
{
    /*public class Lapiz : Dibujo
    {
        public override void Dibujando()
        {
            Console.WriteLine("Pintando con Lapiz");
        }
        public Lapiz() 
        { 
        }*/
    public class Lapiz : IDraw
    {
        public void StartDraw()
        {
            Console.WriteLine("Pintando con Lapiz");
        }
        //public Lapiz()
    }
}
