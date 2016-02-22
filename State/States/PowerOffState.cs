using System;
using State.Device;

namespace State.States
{
    public class PowerOffState: IState
    {
        private readonly Printer _printer;

        public PowerOffState(Printer printer)
        {
            _printer = printer;
        }

        public void On()
        {
            Console.WriteLine("Turning on...");
            _printer.SetState(_printer.WaitingState);
        }

        public void Off()
        {
            Console.WriteLine("I`m not working at this moment...");
        }

        public void Print()
        {
            Console.WriteLine("Can`t print coz I`m shut down");
        }

        public void AddPaper(int count)
        {
            _printer.AddPaper(count);
        }
    }
}
