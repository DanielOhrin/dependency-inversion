using System;

namespace DependencyInversion
{
    public class Mummy : Creature, ICombustable
    {
        public void Burn(string attack)
        {
            if (attack == "Fire")
            {
                Console.WriteLine("The Mummy has burned to death!");
            }
        }
    }
}