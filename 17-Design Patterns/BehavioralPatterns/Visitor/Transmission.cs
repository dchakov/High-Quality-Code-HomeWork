
namespace Visitor
{
    public class Transmission : IElementBase
    {
        public Transmission(string name)
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
