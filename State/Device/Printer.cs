using System;
using State.States;

namespace State.Device
{
    public class Printer
    {
        private int _count;
        private IState _state;
        public PaperOffState PaperOffState { get; set; }
        public PowerOffState PowerOffState { get; set; }
        public PrintState PrintState { get; set; }
        public WaitingState WaitingState { get; set; }
        public int CountPaper
        {
            get { return _count; }
        }


        public Printer()
        {
            PaperOffState = new PaperOffState(this);
            PowerOffState = new PowerOffState(this);
            PrintState = new PrintState(this);
            WaitingState = new WaitingState(this);
            _state = WaitingState;
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public void PrintDocument()
        {
            _state.Print();
        }

        public void PowerOff()
        {
            _state.Off();
        }

        public void PowerOn()
        {
            _state.On();
        }

        public void AddPaper(int count)
        {
            if (count > 0)
            {
                Console.WriteLine("Adding paper...");
                Console.WriteLine("{0} lists of paper have been added", count);
            }

            _count += count;
        }
    }
}
