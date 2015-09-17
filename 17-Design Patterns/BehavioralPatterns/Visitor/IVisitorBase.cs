
namespace Visitor
{
    public interface IVisitorBase
    {
        void Visit(Wheel wheel);
        void Visit(Body body);
        void Visit(Engine engine);
        void Visit(Transmission transmission);
    }
}
