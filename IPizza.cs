using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaMaker
{
    public interface IPizza
    {
        string GetDescription();
        double GetCost();

    }
}
