using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosLibro.JuegosdeArmas
{
    class SwordBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("Using Sword");
        }
    }
}
