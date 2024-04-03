using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaMaker
{
    class MushroomToppingDecorator : ExtraToppingDecorator
    {
        private readonly IPizza _mushroomPizza;

        public MushroomToppingDecorator(IPizza pizza) : base(pizza)
        {
            _mushroomPizza = pizza;            
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " Mushrooms";
        }

        public override double GetCost()
        {
            return base.GetCost() + 2.0;
        }

    }
}
