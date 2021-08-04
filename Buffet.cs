using System;
using System.Collections.Generic;

namespace Wiz_Nin_Sam
{
    public class Buffet
    {
      public List<Food> Menu;
      
      //constructor
      public Buffet()
      {
          Menu = new List<Food>()
          {
              new Food("Salad", 10, false, false),
              new Food("Salami", 50, false, false),
              new Food("Carrot", 1, false, true),
              new Food("Ice Cream", 500, false, true),
              new Food("Jalepeno Pepper", 5, true, false),
              new Food("Spicey Chocolate Pretzels", 100, true, true),
              new Food("Coffee", 100, false, true),
              new Food("Cereal", 75, false, true)
          };
      }
      
      public Food Serve()
      {
        Random rnd = new Random();
        int rndFoodNum = rnd.Next(1, Menu.Count); 
        Console.WriteLine(Menu[rndFoodNum].Name);
        return Menu[rndFoodNum];
      }
    }
}