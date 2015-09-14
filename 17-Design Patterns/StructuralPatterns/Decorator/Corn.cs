namespace Decorator
{
    internal class Corn : SandwichDecorator
    {
        public Corn(Sandwich sandwich)
            : base(sandwich)
        {
            this.Description = "Corn";
        }

        public override string GetDescription()
        {
            return this.Sandwich.GetDescription() + ", " + this.Description;
        }

        public override double GetPrice()
        {
            return this.Sandwich.GetPrice() + 0.23;
        }
    }
}
