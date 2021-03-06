﻿using Command.Devices;

namespace Command.Commands
{
    public class CommandLight : BasicFunctions, ICommand
    {
        private readonly Light _light;

        public CommandLight(string name)
        {
            _light = new Light(name);
        }

        public void Forward()
        {
            _light.SwitchForward();
            PrintLightState(_light.ToString(), _light.State);
        }

        public void Back()
        {
            _light.SwitchBack();
            PrintLightState(_light.ToString(), _light.State);
        }

        public override string ToString()
        {
            return _light.ToString();
        }
    }
}
