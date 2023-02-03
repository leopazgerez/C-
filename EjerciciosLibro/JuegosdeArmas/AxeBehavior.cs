using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosLibro.JuegosdeArmas
{
    class AxeBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("Using Axe");
        }
    }
}
