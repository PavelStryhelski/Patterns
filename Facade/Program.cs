using System;
using Facade.MicrowaveParts;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            new MicrowaveFacade(new Driver(), new EnginePower(), new Notification()).Defrost();

            Console.WriteLine("---------------------------------------------------------------");

            new MicrowaveFacade(new Driver(), new EnginePower(), new Notification()).Heating();

            Console.ReadKey();
        }
    }
}
