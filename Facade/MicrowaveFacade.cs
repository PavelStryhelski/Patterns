using System;
using Facade.MicrowaveParts;

namespace Facade
{
    public class MicrowaveFacade
    {
        private readonly Driver _driver;
        private readonly EnginePower _enginePower;
        private readonly Notification _notification;

        public MicrowaveFacade(Driver driver, EnginePower enginePower, Notification notification)
        {
            _driver = driver;
            _enginePower = enginePower;
            _notification = notification;
        }

        public void Defrost()
        {
            Console.WriteLine("Begin defrosting your meal");
            _notification.BeginWork();
            _enginePower.SetPower = 700;
            _driver.TurnToLeft();
            _driver.TurnToLeft();
            _driver.TurnToLeft();
            _enginePower.SetPower = 400;
            _driver.TurnToRight();
            _driver.TurnToRight();
            _driver.TurnToRight();
            _enginePower.SetPower = 200;
            _driver.TurnToLeft();
            _driver.TurnToRight();
            _driver.TurnToLeft();
            _driver.TurnToRight();
            _driver.TurnToLeft();
            _driver.TurnToRight();
            _enginePower.SetPower = 0;
            _notification.FinishWork();
        }

        public void Heating()
        {
            Console.WriteLine("Begin heating your meal");
            _notification.BeginWork();
            _enginePower.SetPower = 0;
            _driver.TurnToLeft();
            _driver.TurnToLeft();
            _driver.TurnToLeft();
            _enginePower.SetPower = 300;
            _driver.TurnToRight();
            _driver.TurnToRight();
            _driver.TurnToRight();
            _enginePower.SetPower = 500;
            _driver.TurnToLeft();
            _driver.TurnToRight();
            _driver.TurnToLeft();
            _enginePower.SetPower = 800;
            _driver.TurnToRight();
            _driver.TurnToLeft();
            _driver.TurnToRight();
            _enginePower.SetPower = 800;
            _driver.TurnToRight();
            _driver.TurnToLeft();
            _driver.TurnToRight();
            _enginePower.SetPower = 500;
            _driver.TurnToRight();
            _driver.TurnToLeft();
            _driver.TurnToRight();
            _enginePower.SetPower = 150;
            _driver.TurnToRight();
            _driver.TurnToLeft();
            _driver.TurnToRight();
            _enginePower.SetPower = 0;
            _notification.FinishWork();
        }
    }
}
