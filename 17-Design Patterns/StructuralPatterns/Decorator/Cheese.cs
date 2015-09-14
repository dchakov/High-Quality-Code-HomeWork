namespace Decorator
{
    internal class Cheese : SandwichDecorator
    {
        public Cheese(Sandwich sandwich)
            : base(sandwich)
        {
            this.Description = "Cheese";
        }

        public override string GetDescription()
        {
            return this.Sandwich.GetDescription() + ", " + this.Description;
        }

        public override double GetPrice()
        {
            return this.Sandwich.GetPrice() + 1.23;
        }
    }
}
