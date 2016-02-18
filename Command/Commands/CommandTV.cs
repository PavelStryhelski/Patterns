using Command.Commands.States;

namespace Command.Commands
{
    public class CommandTV: BasicFunctions, ICommand
    {
        private readonly TV _tv;
        private readonly string _name;
        
        public CommandTV(string name)
        {
            _tv = new TV();
            _name = name;
        }

        public CommandTV(TV tv, string name)
        {
            _tv = tv;
            _name = name;
        }

        public void Execute()
        {
            switch (_tv.State)
            {
                case SimpleState.On:
                    _tv.TurnOff();
                    break;

                case  SimpleState.Off:
                    _tv.TurnOn();
                    break;
            }
            
            PrintSimpleState(_name, _tv.State);
        }

        public void Undo()
        {
            switch (_tv.State)
            {
                case SimpleState.Off:
                    _tv.TurnOn();
                    break;

                case SimpleState.On:
                    _tv.TurnOff();
                    break;
            }

            PrintSimpleState(_name, _tv.State);
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
