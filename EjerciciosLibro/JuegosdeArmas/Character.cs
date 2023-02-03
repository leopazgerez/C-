using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosLibro.JuegosdeArmas
{
    public abstract class Character
    {
        public IWeaponBehavior Weapon;
        public IWeaponBehavior Weapon1;
       
        public void setWeaponBehavior(IWeaponBehavior weapon, IWeaponBehavior weapon1) 
        {
            this.Weapon = weapon;
            this.Weapon1 = weapon1;
        }
        public void fight()
        {
        }
    }
}
