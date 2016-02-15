using AbstractFactory.CarParts;
using AbstractFactory.CarParts.Engine;

namespace AbstractFactory.Cars
{
    public abstract class Car
    {
        protected IEngine Engine;
        protected IWheels Wheels;
        protected string CarName;

        public abstract void Configure();
    }
}
