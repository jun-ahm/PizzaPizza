using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaMaker
{
    class TomatoToppingDecorator: ExtraToppingDecorator
    {
        private readonly IPizza _tomatoPizza;

        public TomatoToppingDecorator(IPizza pizza)
            : base(pizza)
        {
            _tomatoPizza = pizza;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " Tomato";
        }

        public override double GetCost()
        {
            return base.GetCost() + 2.0;
        }
    }
}
