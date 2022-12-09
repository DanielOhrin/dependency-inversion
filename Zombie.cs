using System;

namespace DependencyInversion
{
    public class Zombie : Creature, ICombustable
    {
        public void Burn(string attack)
        {
            if (attack == "Fire")
            {
                Console.WriteLine("The Zombie dies from the flames!");
            }
        }
    }
}