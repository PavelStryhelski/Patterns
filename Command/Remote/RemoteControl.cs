using System;
using System.Collections.Generic;
using System.Linq;
using Command.Commands;

namespace Command.Remote
{
    public class RemoteControl
    {
        private readonly Dictionary<int, ICommand> _commands;
        private readonly Dictionary<ICommand, string> _commandNames;

        public RemoteControl()
        {
            _commands = new Dictionary<int, ICommand>();
            _commandNames = new Dictionary<ICommand, string>();
        }

        public void AddDevice(int id, ICommand device, string commandName)
        {
            _commands[id] = device;
            _commandNames[device] = commandName;
        }

        public void ForwardCommand(int id)
        {
            if (_commands.ContainsKey(id))
            {
                _commands[id].Forward();
            }
        }

        public void BackCommand(int id)
        {
            if (_commands.ContainsKey(id))
            {
                _commands[id].Back();
            }
        }

        public void RemoveDevice(ICommand command)
        {
            if (!_commands.ContainsValue(command)) return;

            var removeDevice = _commands.FirstOrDefault(x => x.Value == command);
            _commands.Remove(removeDevice.Key);

            _commandNames.Remove(command);
        }

        public void PrintMenu()
        {
            foreach (var command in _commands)
            {
                Console.WriteLine("{0}: \t {1}\n", command.Key, _commandNames[command.Value]);
            }

            Console.WriteLine("0: \t Выход");
        }
    }
}
