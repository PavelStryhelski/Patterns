using System;
using State.Device;

namespace State.States
{
    public class PaperOffState : IState
    {
        private readonly Printer _printer;

        public PaperOffState(Printer printer)
        {
            _printer = printer;
        }

        public void On()
        {
            Console.WriteLine("I`m already working...");
        }

        public void Off()
        {
            Console.WriteLine("Turning off....");
            _printer.SetState(_printer.PowerOffState);
        }

        public void Print()
        {
            if (_printer.CountPaper > 0)
            {
                _printer.SetState(_printer.PrintState);
                _printer.PrintDocument();
            }
            else
            {
                Console.WriteLine("There is no paper here..Can`t print!");
            }
        }

        public void AddPaper(int count)
        {
            _printer.AddPaper(count);
            if (_printer.CountPaper > 0)
            {
                _printer.SetState(_printer.WaitingState);
            }
        }
    }
}
