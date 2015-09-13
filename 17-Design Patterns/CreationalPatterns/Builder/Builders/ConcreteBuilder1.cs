namespace Builder.Builders
{
    public class ConcreteBuilder1 : Builder
    {
        private readonly Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("Part A");
        }

        public override void BuildPartB()
        {
            product.Add("Part B");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}