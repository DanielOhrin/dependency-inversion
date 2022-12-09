using System;

namespace DependencyInversion
{
    public class Ghast : Creature, ICombustable, IDemonic
    {
        public void Burn(string attack)
        {
            if (attack == "Fire")
            {
                Console.WriteLine("The Ghast explodes!");
            }
        }

        public void Douse(string attack)
        {
            if (attack == "Holy Water")
            {
                Console.WriteLine("The Ghast returns to where it came from!");
            }
        }
    }
}