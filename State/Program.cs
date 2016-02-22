using System;
using State.Device;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.PowerOn();
            printer.PrintDocument();
            printer.AddPaper(3);
            printer.PrintDocument();
            printer.PrintDocument();
            printer.PrintDocument();
            printer.PrintDocument();
            printer.PowerOff();

            Console.ReadKey();
        }
    }
}
