using System;
using AbstractFactory.CarParts;
using AbstractFactory.CarParts.Engine;
using AbstractFactory.Factory;

namespace AbstractFactory.Cars
{
    public abstract class Car
    {
        protected IEngine Engine;
        protected IWheels Wheels;
        protected string CarName;
        protected IBasicFactory Factory;

        public void Configure()
        {
            Console.WriteLine("Vehicle name: " + CarName);
            Factory.GetEngine();
            Factory.GetWheels();
        }
    }
}
