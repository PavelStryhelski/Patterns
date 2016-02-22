namespace State.States
{
    public interface IState
    {
        void On();
        void Off();
        void Print();
        void AddPaper(int count);
    }
}
