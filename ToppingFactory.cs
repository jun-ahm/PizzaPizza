using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaMaker
{
    public class ToppingFactory
    {
        public enum Topping 
        {
            
            Mushroom = 1,
            Olive = 2,
            MozzarellaCheese = 3,            
            Pineapple = 4,
            Tomato = 5,
            BulgarianCheese = 6
        }
        
        internal static IPizza CreatePizzaTopping(string toppingNumberFromMenu, IPizza myPizza)
        {
            switch (toppingNumberFromMenu)
            {
                case Topping.Mushroom:
                    myPizza = new MushroomToppingDecorator(myPizza);
                    break;
                case Topping.Olive:
                    myPizza = new OliveToppingDecorator(myPizza);
                    break;
                case Topping.MozzarellaCheese:
                    myPizza = new MozzarellaCheeseToppingDecorator(myPizza);
                    break;
                case Topping.Pineapple:
                    myPizza = new PineappleToppingDecorator(myPizza);
                    break;
                case Topping.Tomato:
                    myPizza = new TomatoToppingDecorator(myPizza);
                    break;
                case Topping.BulgarianCheese:
                    myPizza = new BulgarianCheeseDecorator(myPizza);
                    break;
            }
            Console.WriteLine("Description: " + myPizza.GetDescription());
            Console.WriteLine("Cost: " + myPizza.GetCost());            
            return myPizza;
        }
    }
}
