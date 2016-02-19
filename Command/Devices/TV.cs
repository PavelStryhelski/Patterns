using System;
using Command.Commands.States;

namespace Command.Commands
{
    public class TV
    {
        private readonly string _name;

        public TV(string name)
        {
            _name = name;
        }

        public SimpleState State { get; private set; }

        public void TurnOn()
        {
            State = SimpleState.On;
        }

        public void TurnOff()
        {
            State = SimpleState.Off;
        }
        public override string ToString()
        {
            return _name;
        }
    }
}
