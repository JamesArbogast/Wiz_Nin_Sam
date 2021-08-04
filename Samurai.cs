using System;
using System.Collections.Generic;

namespace Wiz_Nin_Sam
{
    public class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            Name = name;
            Health = 200;
        }
        public new int Attack(Human target)
        {
            int dmg = base.Attack(target);
            if(target.Health < 50)
            {
                target.Health = 0;
            }
            target.Health -= dmg;

            Console.WriteLine(target.Name + "'s Health: " + target.Health + ", " + Name + "'s Health: " + Health);
            return target.Health;
        }

        public int Meditate(Human target)
        {
            int fullHealth = 200;
            Health = fullHealth;
            Console.WriteLine(target.Name + "'s Health: " + target.Health + ", " + Name + "'s Health: " + Health);
            return target.Health;
        }
    }
}