
namespace Visitor
{
    interface IElementBase
    {
        void Accept(IVisitorBase visitor);
    }
}
