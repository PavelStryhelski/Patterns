using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Autos
{
    public class BMW : AutoBase
    {
        private double cost = 12000;

        public BMW()
        {
            Description = "BMW x6  - кроссовер";
        }

        public override double GetCost()
        {
            return cost;
        }
    }
}
