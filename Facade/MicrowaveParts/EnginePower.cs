using System;

namespace Facade.MicrowaveParts
{
    public class EnginePower
    {
        private int _power;

        public int SetPower
        {
            get
            {
                return _power;
            }
            set
            {
                _power = value;
                Console.WriteLine("Microwave power is {0} Watt", _power);
            }

        }
    }
}
