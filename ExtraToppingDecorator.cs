using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaMaker
{
    abstract class ExtraToppingDecorator : IPizza
    {
        #region IPizza Members
        
        private readonly IPizza _pizza;

        public ExtraToppingDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual string GetDescription()
        {
            return _pizza.GetDescription();
        }

        public virtual double GetCost()
        {
            return _pizza.GetCost();
        }

        #endregion
    }
}
