using Command.Devices;

namespace Command.Commands
{
    public class CommandLight: BasicFunctions, ICommand
    {
        private readonly Light _light;
        private readonly string _name;

        public CommandLight(string name)
        {
            _light = new Light();
            _name = name;
        }

        public CommandLight(Light light, string name)
        {
            _light = light;
            _name = name;
        }

        public void Execute()
        {
            _light.Forward();
            PrintLightState(_name, _light.State);
        }

        public void Undo()
        {
            _light.Back();
            PrintLightState(_name, _light.State);
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
