using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaMaker
{
    class OliveToppingDecorator: ExtraToppingDecorator
    {
        private readonly IPizza _olivePizza;

        public OliveToppingDecorator(IPizza pizza)
            : base(pizza)
        {
            _olivePizza = pizza;            
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " Olives";
        }

        public override double GetCost()
        {
            return base.GetCost() + 2.0;
        }

    }
}