using System;

namespace DependencyInversion
{
    public class Vampire : Creature, ICombustable, IWereCreature
    {
        public void Burn(string attack)
        {
            if (attack == "Fire")
            {
                Console.WriteLine("The Vampire melts away!");
            }
        }

        public void Stab(string attack)
        {
            if (attack == "Silver")
            {
                Console.WriteLine("The Vampire suffers a painful death!");
            }
        }
    }
}