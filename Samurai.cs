using System;
using System.Collections.Generic;

namespace Wiz_Nin_Sam
{
    public class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            Name = name;
            health = 200;
        }
        public new int Attack(Human target)
        {
            int dmg = base.Attack(target);
            if(target.health < 50)
            {
                target.health = 0;
            }
            target.health -= dmg;

            Console.WriteLine(target.Name + "'s Health: " + target.Health + ", " + Name + "'s Health: " + health);
            return target.Health;
        }

        public int Meditate(Human target)
        {
            int fullHealth = 200;
            health = fullHealth;
            Console.WriteLine(target.Name + "'s Health: " + target.Health + ", " + Name + "'s Health: " + health);
            return target.Health;
        }
    }
}