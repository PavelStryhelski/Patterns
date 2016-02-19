using Command.Commands.States;

namespace Command.Commands
{
    public class CommandTV: BasicFunctions, ICommand
    {
        private readonly TV _tv;

        public CommandTV(string deviceName)
        {
            _tv = new TV(deviceName);
        }

        public void Forward()
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
            
            PrintSimpleState(_tv.ToString(), _tv.State);
        }

        public void Back()
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

            PrintSimpleState(_tv.ToString(), _tv.State);
        }

        public override string ToString()
        {
            return _tv.ToString();
        }
    }
}
