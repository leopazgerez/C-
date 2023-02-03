using System;

namespace EjerciciosLibro.JuegosdeArmas
{
    class Program
    {
        static void Main(string[] args)
        {
            Character Reina = new Queen();
            Reina.setWeaponBehavior(new KnifeBehavior(), new BowAndArrowBehavior()); ;
            Reina.Weapon.useWeapon();
            Reina.setWeaponBehavior(new SwordBehavior(), new AxeBehavior());
            Reina.Weapon.useWeapon();
        }
    }
}
