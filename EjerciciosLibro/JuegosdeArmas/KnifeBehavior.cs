using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosLibro.JuegosdeArmas
{
    public  class KnifeBehavior : IWeaponBehavior
    {
        public void useWeapon() 
        {
            Console.WriteLine("Using Knife");
        }
    }
}
