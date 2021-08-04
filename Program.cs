using System;
using System.Collections.Generic;

namespace Wiz_Nin_Sam
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Human james = new Human("James", 2, 4, 5);
            // Human evilJames = new Human("Evil James", 4, 2, 3);
            // james.Attack(evilJames);
        }
    }

    public class Human 
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int health;
        public int Health 
        {
            get {return health;}
        }

        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
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
            target.health -= 5 * Strength;
            Console.WriteLine(target.Name + "'s Health: " + target.Health);
            return target.Health;
        }
    
    }
}

