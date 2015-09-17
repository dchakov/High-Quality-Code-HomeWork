
namespace Visitor
{
    public class Body : IElementBase
    {
        public Body(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public void Accept(IVisitorBase visitor)
        {
            visitor.Visit(this);
        }
    }
}
