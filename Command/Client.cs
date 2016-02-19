using System;
using Command.Commands;
using Command.Devices;
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
            remoteControl.AddDevice(1, tv, "Включить/выключить телевизор в гостинной");
            remoteControl.AddDevice(2, tv2, "Включить/выключить телевизор в спальне");
            remoteControl.AddDevice(3, tv3, "Включить/выключить телевизор на кухне");
            remoteControl.AddDevice(4, light1, "Переключить режима света в гостинной вперед");
            remoteControl.AddDevice(5, light1, "Переключить режима света в гостинной назад");

            remoteControl.PrintMenu();

            var input = Console.ReadLine();


            while (input != "0")
            {
                if (input != null)
                {
                    var button = Int32.Parse(input);

                    if (button == 5 )
                    {
                        remoteControl.BackCommand(button);
                    }
                    else
                    {
                        remoteControl.ForwardCommand(button);
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
