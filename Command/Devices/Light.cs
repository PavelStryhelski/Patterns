using Command.States;

namespace Command.Devices
{
    public class Light
    {

        private readonly string _name;
        public LightState State { get; set; }

        public Light(string name)
        {
            _name = name;
        }

        public void SwitchForward()
        {
            switch (State)
            {
                case LightState.Off:
                    State = LightState.Low;
                    break;
                case LightState.Low:
                    State = LightState.Medium;
                    break;
                case LightState.Medium:
                    State = LightState.High;
                    break;
                case LightState.High:
                    State = LightState.Off;
                    break;
            }
        }
        public void SwitchBack()
        {
            switch (State)
            {
                case LightState.Off:
                    State = LightState.High;
                    break;
                case LightState.Low:
                    State = LightState.Off;
                    break;
                case LightState.Medium:
                    State = LightState.Low;
                    break;
                case LightState.High:
                    State = LightState.Medium;
                    break;
            }
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
