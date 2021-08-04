using System;
using System.Collections.Generic;

namespace Wiz_Nin_Sam
{
    public class Program
    {
        static void Main(string[] args)
        {
            Buffet rndFood = new Buffet();
            Ninja james = new Ninja("James");
            Wizard evilJames = new Wizard("Evil James");
            Samurai lessEvilJames = new Samurai("Less Evil James");
            Console.WriteLine(james.Name + "'s Health: " + james.Health + " | " + evilJames.Name + "'s Health: " + evilJames.Health + " | " + lessEvilJames.Name + "'s Health: " + lessEvilJames.Health);
            james.Steal(evilJames);
            evilJames.Heal(evilJames);
            lessEvilJames.Attack(james);
            james.Attack(lessEvilJames);
            lessEvilJames.Meditate(lessEvilJames);
            james.Eat(rndFood.Serve());

        }
    }
}

