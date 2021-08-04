

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

          int dmg = 5 * Intelligence;
          target.health -= dmg;
          health += dmg;
          Console.WriteLine(target.Name + "'s Health: " + target.Health + ", " + Name + "'s Health: " + health);
          return target.Health;
        }
    }
}
