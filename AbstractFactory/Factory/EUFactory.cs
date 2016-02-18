using AbstractFactory.CarParts;
using AbstractFactory.CarParts.Engine;
using AbstractFactory.CarParts.Wheels;

namespace AbstractFactory.Factory
{
    public class EUFactory: IBasicFactory
    {
        public IEngine GetEngine()
        {
            return new DieselEngine();
        }

        public IWheels GetWheels()
        {
            return new BigWheels();
        }
    }
}
