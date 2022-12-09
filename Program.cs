using System;

namespace DependencyInversion
{
    class Program
    {
        static void Main()
        {
            Hunter VonRimmersmark = new Hunter("Erich", "Von Rimmersmark");

            Zombie zombie = new Zombie();
            Demon demon = new Demon();
            Ghast ghast = new Ghast();
            Ghoul ghoul = new Ghoul();
            Mummy mummy = new Mummy();
            Vampire vampire = new Vampire();
            Wight wight = new Wight();

            VonRimmersmark.Ignite(zombie);
            VonRimmersmark.WieldSilver(demon);
            VonRimmersmark.SplashWater(ghast);

            VonRimmersmark.WieldPoultice(ghoul);
            VonRimmersmark.WieldPoultice(mummy);
            VonRimmersmark.WieldPoultice(vampire);
            VonRimmersmark.WieldPoultice(wight);
        }
    }
}
