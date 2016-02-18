using System;
using Command.Commands;
using Command.Remote;

namespace Command
{
    class Client
    {
        static void Main(string[] args)
        {
            var tv = new CommandTV("Телевизор в гостиной");
            var tv2 = new CommandTV("Телевизор в спальне");
            var tv3 = new CommandTV("Телевизор на кухне");
            var light1 = new CommandLight("Свет в гостиной");

            var remoteControl = new RemoteControl();
            remoteControl.AddDevice(1, tv);
            remoteControl.AddDevice(3, tv2);
            remoteControl.AddDevice(5, tv3);
            remoteControl.AddDevice(7, light1);
            remoteControl.AddDevice(8, light1);

            remoteControl.PrintMenu();

            var input = Console.ReadLine();


            while (input != "0")
            {
                if (input != null)
                {
                    var button = Int32.Parse(input);

                    if ((int)button % 2 == 0 )
                    {
                        remoteControl.UndoCommand(button);
                    }
                    else
                    {
                        remoteControl.RunCommand(button);
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
