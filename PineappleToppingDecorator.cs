using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaMaker
{
    class PineappleToppingDecorator: ExtraToppingDecorator
    {
        private readonly IPizza _pineapplePizza;

        public PineappleToppingDecorator(IPizza pizza)
            : base(pizza)
        {
            _pineapplePizza = pizza;            
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " Pineapple";
        }

        public override double GetCost()
        {
            return base.GetCost() + 2.0;
        }

    }
}

