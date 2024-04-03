using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaMaker
{
    public class ToppingFactory
    {
        internal static IPizza CreatePizzaTopping(string toppingNumberFromMenu, IPizza myPizza)
        {
            switch (toppingNumberFromMenu)
            {
                case "1":
                    myPizza = new MushroomToppingDecorator(myPizza);
                    break;
                case "2":
                    myPizza = new OliveToppingDecorator(myPizza);
                    break;
                case "3":
                    myPizza = new MozzarellaCheeseToppingDecorator(myPizza);
                    break;
                case "4":
                    myPizza = new PineappleToppingDecorator(myPizza);
                    break;
                case "5":
                    myPizza = new TomatoToppingDecorator(myPizza);
                    break;
                case "6":
                    myPizza = new BulgarianCheeseDecorator(myPizza);
                    break;
            }
            Console.WriteLine("Description: " + myPizza.GetDescription());
            Console.WriteLine("Cost: " + myPizza.GetCost());            
            return myPizza;
        }
    }
}
