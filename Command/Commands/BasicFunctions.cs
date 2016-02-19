using System;
using Command.Commands.States;
using Command.States;

namespace Command.Commands
{
    public abstract class BasicFunctions
    {
        private const string On = " включен";
        private const string Off = " выключен";
        private const string Low = " слабый";
        private const string Medium = " средний";
        private const string High = " сильный";

        public void PrintSimpleState(string devicename, SimpleState state)
        {
            switch (state)
            {
                case SimpleState.On:
                    Console.WriteLine("{0} {1}", devicename, On);
                    break;

                case SimpleState.Off:
                    Console.WriteLine("{0} {1}", devicename, Off);
                    break;
            }
        }

        public void PrintLightState(string devicename, LightState state)
        {
            switch (state)
            {
                case LightState.Off:
                    Console.WriteLine("{0} {1}", devicename, Off);
                    break;
                case LightState.Low:
                    Console.WriteLine("{0} {1}", devicename, Low);
                    break;
                case LightState.Medium:
                    Console.WriteLine("{0} {1}", devicename, Medium);
                    break;
                case LightState.High:
                    Console.WriteLine("{0} {1}", devicename, High);
                    break;
            }
        }
    }
}
