namespace Decorator.Autos
{
    public abstract class AutoBase
    {
        protected string Description;

        public string GetDescription()
        {
            return Description;
        }

        public abstract double GetCost();
    }
}
