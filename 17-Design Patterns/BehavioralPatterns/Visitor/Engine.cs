
namespace Visitor
{
    public class Engine : IElementBase
    {
        public Engine(string name)
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
