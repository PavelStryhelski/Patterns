using System;
using System.Collections.Generic;
using System.Linq;
using Command.Commands;

namespace Command.Remote
{
    public class RemoteControl
    {
        private readonly Dictionary<int, ICommand> _devices;

        public RemoteControl()
        {
            _devices = new Dictionary<int, ICommand>();
        }

        public void AddDevice(int id, ICommand device)
        {
            _devices[id] = device;
        }

        public void RunCommand(int id)
        {
            if (_devices.ContainsKey(id))
            {
                _devices[id].Execute();
            }
        }

        public void UndoCommand(int id)
        {
            if (_devices.ContainsKey(id))
            {
                _devices[id].Undo();
            }
        }

        public void RemoveDevice(ICommand device)
        {
            if (!_devices.ContainsValue(device)) return;

            var removeDevice = _devices.FirstOrDefault(x => x.Value == device);
            _devices.Remove(removeDevice.Key);
        }

        public void PrintMenu()
        {
            foreach (var device in _devices)
            {
                Console.WriteLine("{0}: \t {1}\n", device.Key, device.Value);
            }

            Console.WriteLine("0: \t Выход");
        }
    }
}
