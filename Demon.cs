using System;

namespace DependencyInversion
{
    public class Demon : Creature, ICombustable, IDemonic, IWereCreature
    {
        public void Burn(string attack)
        {
            if (attack == "Fire")
            {
                Console.WriteLine("The Demon vanishes!");
            }
        }

        public void Douse(string attack)
        {
            if (attack == "Holy Water")
            {
                Console.WriteLine("The Demon melts away!");
            }
        }

        public void Stab(string attack)
        {
            if (attack == "Silver")
            {
                Console.WriteLine("The Demon falls to your blade!");
            }
        }
    }
}