using System;
using State.Device;

namespace State.States
{
    public class PrintState: IState
    {
        private readonly Printer _printer;

        public PrintState(Printer printer)
        {
            _printer = printer;
        }

        public void On()
        {
            Console.WriteLine("I`m already working");
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
                Console.WriteLine("Printing...");
                _printer.AddPaper(-1);
                _printer.SetState(_printer.WaitingState);
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
