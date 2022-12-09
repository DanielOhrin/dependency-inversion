using System;
using System.Collections.Generic;

namespace DependencyInversion
{
    public class Hunter
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<string> Weapons { get; } = new List<string>() {
        "Silver", "Fire", "Holy Water"
    };

        public Hunter(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }

        public void SplashWater(IDemonic creature)
        {
            creature.Douse("Holy Water");  // Kills with holy water
        }

        public void Ignite(ICombustable creature)
        {
            creature.Burn("Fire");  // Kills with fire
        }

        public void WieldSilver(IWereCreature creature)
        {
            creature.Stab("Silver");   // Stabs with silver knife
        }

        public void WieldPoultice(Creature creature)
        {
            Console.WriteLine($"The {creature} flattens like a pancake under the power of the Ultimate Weapon!");
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} kills monsters with the following weapons: {String.Join(", ", Weapons)}";
        }
    }
}