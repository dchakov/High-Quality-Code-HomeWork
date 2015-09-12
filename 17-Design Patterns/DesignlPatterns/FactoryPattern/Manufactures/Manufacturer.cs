namespace FactoryPattern.Manufactures
{
    using FactoryPattern.Products;

    public abstract class Manufacturer
    {
        public abstract IProduct CreateProduct();
    }
}
