using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaMaker
{
    public class BasePizza : IPizza
    {
        #region IPizza Members

        public string GetDescription()
        {
            return "Base pizza with ";
        }

        public double GetCost()
        {
            return 25.0;
        }

        #endregion
    }
}
