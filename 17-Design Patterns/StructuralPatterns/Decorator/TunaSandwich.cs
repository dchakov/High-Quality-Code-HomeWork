namespace Decorator
{
    public class TunaSandwich : Sandwich
    {
        public TunaSandwich()
        {
            this.Description = "Tuna Sandwitch";
        }
        public override string GetDescription()
        {
            return this.Description;
        }

        public override double GetPrice()
        {
            return 5.20;
        }
    }
}
