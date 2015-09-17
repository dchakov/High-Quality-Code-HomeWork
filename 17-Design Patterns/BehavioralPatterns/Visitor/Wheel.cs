
namespace Visitor
{
    public class Wheel : IElementBase
    {
        public Wheel(string name)
        {
            this.Name = name;
        }

        public string Tire { get; set; }

        public string Name { get; set; }

        public void Accept(IVisitorBase visitor)
        {
            visitor.Visit(this);
        }
    }
}
