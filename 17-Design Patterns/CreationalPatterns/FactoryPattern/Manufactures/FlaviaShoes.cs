namespace FactoryPattern.Manufactures
{
    using FactoryPattern.Products;

    public class FlaviaShoes:Manufacturer
    {

        public override IProduct CreateProduct()
        {
            IProduct winterShoes = new Shoes();
            winterShoes.SetPrice(50.50);
            return winterShoes;
        }
    }
}
