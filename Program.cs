using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            var anotherPizza = false;
            do
            {
                anotherPizza = MakePizza();
            }
            while (anotherPizza);
        }

        private static bool MakePizza()
        {
            Console.WriteLine("Making pizza with dough");
            IPizza myPizza = new BasePizza();
            //Console.WriteLine($"Description: {myPizza.GetDescription()}");
            //Console.WriteLine($"Cost: {myPizza.GetCost()}");

            Console.WriteLine("Description: " + myPizza.GetDescription());
            Console.WriteLine("Cost: " + myPizza.GetCost());            

            Console.WriteLine("You can choose and add upto 3 toppings from the below list. The cost for each topping is also provided");
            Console.WriteLine("1. Mushrooms cost $2");
            Console.WriteLine("2. Olives cost $2");
            Console.WriteLine("3. Mozzarella cost $3");
            Console.WriteLine("4. Pineapple cost $2");
            Console.WriteLine("5. Tomatoes cost $2");
            Console.WriteLine("6. Bulgarian Cheese cost $3");

            //maximum of three toppings can be added
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the number from above list for your " + (i + 1) + " topping: ");
                var option = Console.ReadLine();
                int value;
                if (int.TryParse(option, out value))
                {
                    if (Convert.ToInt32(option) < 1 || Convert.ToInt32(option) > 6)
                    {
                        Console.WriteLine("No such topping exists, pls re-enter your option again.");
                        i = i - 1;
                    }
                    else
                        myPizza = ToppingFactory.CreatePizzaTopping(option, myPizza);
                }
                else
                {
                    Console.WriteLine("Only numbers between 1 and 6 are valid. Pls re-enter again.");
                    i = i - 1;
                }
            }
            Console.WriteLine("Would you like to order another pizza. Enter 'Y' for Yes and 'N' for No.");
            var anotherPizza = Console.ReadLine();
            if (anotherPizza.Trim().ToUpper() == "Y")
                return true;
            else
                return false;
        }        
    }
}
