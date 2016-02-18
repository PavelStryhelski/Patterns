using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.CarParts;
using AbstractFactory.CarParts.Engine;

namespace AbstractFactory.Factory
{
    public interface IBasicFactory
    {
        IEngine GetEngine();
        IWheels GetWheels();
    }
}
