using Command.States;

namespace Command.Devices
{
    public class Light
    {
        public LightState State { get; set; }

        public void Forward()
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

        public void Back()
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
    }
}
