using System;
using System.Collections.Generic;
using System.Text;

namespace Drawing
{
    /*public class Aerosol : Dibujo
    {
        public override void Dibujando()
        {
            Console.WriteLine("Pintando con Aeorosol");
        }
        public Aerosol()
        {

        }*/
    public class Aerosol : IDraw
    {
        public void StartDraw()
        {
            Console.WriteLine("Pintando con Aeorosol");
        }
        public Aerosol()
        {

        }
    }
}
