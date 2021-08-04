using System;

namespace Wiz_Nin_Sam
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
          Name = name;
          Intelligence = 25;
        }

        public new int Attack(Human target)
        {
          int dmg = 5 * Intelligence;
          target.Health -= dmg;
          Health += dmg;
          Console.WriteLine(target.Name + "'s Health: " + target.Health + ", " + Name + "'s Health: " + Health);
          return target.Health;
        }

        public int Heal(Human target)
        {
          int healing = 10 * Intelligence;
          target.Health += healing;
          Console.WriteLine(target.Name + "'s Health: " + target.Health + ", " + Name + "'s Health: " + Health);
          return target.Health;
        }

    }
}