using System;
using Command.Commands.States;

namespace Command.Commands
{
    public class TV
    {
        public SimpleState State { get; private set; }

        public void TurnOn()
        {
            State = SimpleState.On;
        }

        public void TurnOff()
        {
            State = SimpleState.Off;
        }
    }
}
