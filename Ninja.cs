using System;
using System.Collections.Generic;

namespace Wiz_Nin_Sam
{
    public class Ninja : Human
    {
        private int calorieIntake;
        private bool isFull;
        public List<Food> FoodHistory;
        public int CalorieIntake {get; set;}
        public bool IsFull 
        {

            get 
            { 
                if(CalorieIntake > 1200)
                {
                    return true; 
                } 
                else 
                {
                    return false;
                }
            }
            set { 
                if(CalorieIntake > 1200)
                {
                    IsFull = value; 
                } 
                else 
                {
                    IsFull = value;
                }
            }
        }
        public Ninja(string name) : base(name)
        {
            Name = name;
            Dexterity = 175;
            CalorieIntake = 0;
            FoodHistory = new List<Food>();
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
            target.Health -= dmg;

            Console.WriteLine(target.Name + "'s Health: " + target.Health + ", " + Name + "'s Health: " + Health);
            return target.Health;
        }

        public int Steal(Human target)
        {
            target.Health -= 5;
            Health += 5;
            Console.WriteLine(target.Name + "'s Health: " + target.Health + ", " + Name + "'s Health: " + Health);
            return target.Health;
        }

        public void Eat(Food food)
        {
            if(!isFull)
            {
                CalorieIntake += food.Calories;
                FoodHistory.Add(food);
                Console.WriteLine($"{food.Name} is spicey: {food.IsSpicy}, is sweet {food.IsSweet}, calorie intake is {CalorieIntake}");
            }
            else{
                Console.WriteLine("Ninja is full!!!");
            }
        }
    }
}
