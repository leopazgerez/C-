using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosLibro.JuegosdeArmas
{
    class BowAndArrowBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("Using Bow and Arrow");
        }
    }
}
