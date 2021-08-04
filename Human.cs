using System;

namespace Wiz_Nin_Sam
{
    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        public int Health 
        {
            //if these are are left blank it will default to following
            get {return health;}
            set {health = value;}
            // get;
            // set;
        }

        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }
        public Human(string name, int strength, int intelligence, int dexterity, int hp)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            health = hp;
        }

        public int Attack(Human target)
        {
            target.Health -= 5 * Strength;
            Console.WriteLine(target.Name + "'s Health: " + target.Health);
            return target.Health;
        }
    }
}