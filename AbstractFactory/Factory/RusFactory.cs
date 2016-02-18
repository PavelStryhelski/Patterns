using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.CarParts;
using AbstractFactory.CarParts.Engine;
using AbstractFactory.CarParts.Wheels;

namespace AbstractFactory.Factory
{
    public class RusFactory: IBasicFactory
    {
        public IEngine GetEngine()
        {
            return new GasolineEngine();
        }

        public IWheels GetWheels()
        {
            return new MediumWheels();
        }
    }
}
