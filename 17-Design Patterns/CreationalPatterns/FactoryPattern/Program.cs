namespace FactoryPattern
{
    using System;
    using FactoryPattern.Products;
    using FactoryPattern.Manufactures;

    public static class Program
    {
        public static void Main()
        {
            var manufacturer = new FlaviaShoes();
            var shoe = manufacturer.CreateProduct();
            Console.WriteLine(shoe.SetPrice(30.2));
            Console.WriteLine(shoe.GetName());
        }
    }
}
