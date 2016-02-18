using System;
using Command.Commands.States;
using Command.States;

namespace Command.Commands
{
    public abstract class BasicFunctions
    {
        public string On = " включен";
        public string Off = " выключен";
        public string Low = " слабый";
        public string Medium = " средний";
        public string High = " сильный";

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
                case Command.States.LightState.Off:
                    Console.WriteLine("{0} {1}", devicename, Off);
                    break;
                case Command.States.LightState.Low:
                    Console.WriteLine("{0} {1}", devicename, Low);
                    break;
                case Command.States.LightState.Medium:
                    Console.WriteLine("{0} {1}", devicename, Medium);
                    break;
                case Command.States.LightState.High:
                    Console.WriteLine("{0} {1}", devicename, High);
                    break;
            }
        }
    }
}
