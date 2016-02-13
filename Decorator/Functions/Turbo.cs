using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Autos;

namespace Decorator.Functions
{
    public class Turbo : AbstractFunction
    {
        private double tiresCost = 1500;
        private readonly AutoBase _autoBase;

        public Turbo(AutoBase autoBase)
        {
            _autoBase = autoBase;

            if (_autoBase != null)
            {
                Description = _autoBase.GetDescription() +  string.Format(" + Турбо {0}", tiresCost);
            }
        }

        public override double GetCost()
        {
            if (_autoBase != null)
            {
                tiresCost += _autoBase.GetCost();
            }

            return tiresCost;
        }
    }
}
