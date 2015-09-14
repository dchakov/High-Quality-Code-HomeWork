namespace Decorator
{
    internal abstract class SandwichDecorator : Sandwich
    {
        protected Sandwich Sandwich { get; private set; }

        protected SandwichDecorator(Sandwich sandwich)
        {
            this.Sandwich = sandwich;
        }

        public override string GetDescription()
        {
            return this.Sandwich.GetDescription();
        }

        public override double GetPrice()
        {
            return this.Sandwich.GetPrice();
        }
    }
}
