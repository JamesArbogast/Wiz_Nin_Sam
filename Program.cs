using System;
using System.Collections.Generic;

namespace Wiz_Nin_Sam
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ninja james = new Ninja("James");
            Wizard evilJames = new Wizard("Evil James");
            Samurai lessEvilJames = new Samurai("Less Evil James");
            Console.WriteLine(james.Name + "'s Health: " + james.health + " | " + evilJames.Name + "'s Health: " + evilJames.health + " | " + lessEvilJames.Name + "'s Health: " + lessEvilJames.health);
            james.Steal(evilJames);
            evilJames.Heal(evilJames);
            lessEvilJames.Attack(james);
            james.Attack(lessEvilJames);
            lessEvilJames.Meditate(lessEvilJames);
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

