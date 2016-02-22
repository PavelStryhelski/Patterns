using System;
using State.Device;

namespace State.States
{
    public class WaitingState: IState
    {
        private readonly Printer _printer;

        public WaitingState(Printer printer)
        {
            _printer = printer;
        }

        public void On()
        {
            Console.WriteLine("I`m already ON...");
        }

        public void Off()
        {
            Console.WriteLine("Turning off...");
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
                _printer.SetState(_printer.PaperOffState);
                _printer.PrintDocument();
            }
        }

        public void AddPaper(int count)
        {
            _printer.AddPaper(count);
        }
    }
}
