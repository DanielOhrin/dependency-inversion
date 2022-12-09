using System;

namespace DependencyInversion
{
    public class Wight : Creature, IWereCreature
    {
        public void Stab(string attack)
        {
            if (attack == "Silver")
            {
                Console.WriteLine("The Wight falls to its knees!");
            }
        }
    }
}