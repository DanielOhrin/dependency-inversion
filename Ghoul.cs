using System;

namespace DependencyInversion
{
    public class Ghoul : Creature, IWereCreature, IDemonic
    {
        public void Stab(string attack)
        {
            if (attack == "Silver")
            {
                Console.WriteLine("The Ghoul returns to the underworld!");
            }
        }

        public void Douse(string attack)
        {
            if (attack == "Holy Water")
            {
                Console.WriteLine("The Ghoul returns to the underworld!");
            }
        }
    }
}