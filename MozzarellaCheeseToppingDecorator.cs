using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaMaker
{
    class MozzarellaCheeseToppingDecorator: ExtraToppingDecorator
    {
        private readonly IPizza _mozzarellaCheesePizza;

        public MozzarellaCheeseToppingDecorator(IPizza pizza)
            : base(pizza)
        {
            _mozzarellaCheesePizza = pizza;            
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " Mozzarella Cheese";
        }

        public override double GetCost()
        {
            return base.GetCost() + 3.0;
        }
    }
}
