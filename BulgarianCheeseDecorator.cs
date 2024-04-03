using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaMaker
{
    class BulgarianCheeseDecorator : ExtraToppingDecorator
    {
        private readonly IPizza _bulgarianCheesePizza;

        public BulgarianCheeseDecorator(IPizza pizza)
            : base(pizza)
        {
            _bulgarianCheesePizza = pizza;            
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " Bulgarian Cheese";
        }

        public override double GetCost()
        {
            return base.GetCost() + 3.0;
        }
    }
}