using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Autos
{
    public class AUDI: AutoBase
    {
        private double cost = 8000;

        public AUDI()
        {
            Description = "АУДИ А8  - супер тачка";
        }

        public override double GetCost()
        {
            return cost;
        }
    }
}
