using System;

namespace Wiz_Nin_Sam
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Name = name;
            Dexterity = 175;
        }

        public new int Attack(Human target)
        {
            int dmg = 5 * Dexterity;
            Random rnd = new Random();
            int crit = rnd.Next(1, 10); 
            if(crit <= 2)
            {
                dmg += 10;
                Console.WriteLine("Critical Hit!!!");
            }
            target.health -= dmg;

            Console.WriteLine(target.Name + "'s Health: " + target.Health + ", " + Name + "'s Health: " + health);
            return target.Health;
        }

        public int Steal(Human target)
        {
            target.health -= 5;
            health += 5;
            Console.WriteLine(target.Name + "'s Health: " + target.Health + ", " + Name + "'s Health: " + health);
            return target.Health;
        }
    }
}
