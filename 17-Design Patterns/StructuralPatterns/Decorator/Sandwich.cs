namespace Decorator
{
    public abstract class Sandwich
    {
        public abstract string GetDescription();

        public abstract double GetPrice();

        public string Description { get; set; }
    }
}
