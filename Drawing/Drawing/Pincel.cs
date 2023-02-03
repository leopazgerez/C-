using System;
using System.Collections.Generic;
using System.Text;

namespace Drawing
{
    /*public class Pincel : Dibujo
     {
         public override void Dibujando()
         {
             Console.WriteLine("Pintando con Pincel");
         }
         public Pincel()
         {

         }*/
    public class Pincel : IDraw
    {
        public void StartDraw()
        {
            Console.WriteLine("Pintando con Pincel");
        }
        public Pincel()
        {
        }
   

    }
}
