namespace Decorator
{
    public class VeggieSandwich : Sandwich
    {
        public VeggieSandwich()
        {
            this.Description = "Veggie Sandwitch";
        }

        public override string GetDescription()
        {
            return this.Description;
        }

        public override double GetPrice()
        {
            return 2.70;
        }
    }
}
