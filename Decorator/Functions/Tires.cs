using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Autos;

namespace Decorator.Functions
{
    public class Tires : AbstractFunction
    {
        private double tiresCost = 1100;
        private readonly AutoBase _autoBase;

        public Tires(AutoBase autoBase)
        {
            _autoBase = autoBase;

            if (_autoBase != null)
            {
                Description = _autoBase.GetDescription() + string.Format(" + Шины {0}", tiresCost);
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
