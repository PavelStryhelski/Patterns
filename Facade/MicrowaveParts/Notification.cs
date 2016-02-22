using System;

namespace Facade.MicrowaveParts
{
    public class Notification
    {
        public void BeginWork()
        {
            Console.WriteLine("*BIP*  Start working");
        }

        public void FinishWork()
        {
            Console.WriteLine("*BIP**BIP**BIP* Finish!");
        }
    }
}
