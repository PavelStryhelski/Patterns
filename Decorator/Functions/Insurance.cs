using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Autos;

namespace Decorator.Functions
{
    public class Insurance: AbstractFunction
    {
        private double insuranceCost = 500;
        private readonly AutoBase _autoBase;

        public Insurance(AutoBase autoBase)
        {
            _autoBase = autoBase;

            if (_autoBase != null)
            {
                Description = _autoBase.GetDescription() + string.Format(" + Страховка {0}", insuranceCost);
            }
        }

        public override double GetCost()
        {
            if (_autoBase != null)
            {
                insuranceCost += _autoBase.GetCost();
            }

            return insuranceCost;
        }
    }
}
