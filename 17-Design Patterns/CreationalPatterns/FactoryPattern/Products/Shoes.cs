namespace FactoryPattern.Products
{
    public class Shoes:IProduct
    {
        private double price;

        public string GetName()
        {
            return "Winter shoes";
        }

        public string SetPrice(double price)
        {
            this.price = price;
            return "success";
        }
    }
}
