namespace Decorator
{
    internal class Olives : SandwichDecorator
    {
        public Olives(Sandwich sandwich)
            : base(sandwich)
        {
            this.Description = "Olives";
        }

        public override string GetDescription()
        {
            return this.Sandwich.GetDescription() + ", " + this.Description;
        }

        public override double GetPrice()
        {
            return this.Sandwich.GetPrice() + 0.78;
        }
    }
}
